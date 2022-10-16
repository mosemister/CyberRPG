using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberRPG.Vehicle;
using Godot;

namespace CyberRPG.Vehicle.Car.Basic
{
    public class PassengerFrontDoor : Spatial, IDoor
    {

        private DoorState doorState;

        private bool doorLifted;
        private bool doorRotated;
        private bool doorElevated;

        private Transform closedTransform;
        private Transform liftedTransform;

        private static readonly Transform ROTATED_TRANSFORM = new Transform(new Basis()
        {
            Column0 = new Vector3(1, 0, 0),
            Column1 = new Vector3(0, 0.8472548f, -0.5311859f),
            Column2 = new Vector3(0, 0.5311859f, 0.8472548f),
            Row0 = new Vector3(1, 0, 0),
            Row1 = new Vector3(0, 0.8472548f, 0.5311859f),
            Row2 = new Vector3(0, -0.5311859f, 0.8472548f),
            Scale = new Vector3(1, 0.9999995f, 0.9999995f),
            x = new Vector3(1, 0, 0),
            y = new Vector3(0, 0.8472548f, -0.5311859f),
            z = new Vector3(0, 0.5311859f, 0.8472548f)
        }, new Vector3(0, 2, 1));

        private static readonly Transform OPEN_TRANSFORM = new Transform(new Basis()
        {
            Column0 = new Vector3(1, 0, 0),
            Column1 = new Vector3(0, 0.8419006f, -0.5396317f),
            Column2 = new Vector3(0, 0.5396317f, 0.8419006f),
            Row0 = new Vector3(1, 0, 0),
            Row1 = new Vector3(0, 0.8419006f, 0.5396317f),
            Row2 = new Vector3(0, -0.5396317f, 0.8419006f),
            Scale = new Vector3(1, 0.9999995f, 0.9999995f),
            x = new Vector3(1, 0, 0),
            y = new Vector3(0, 0.8419006f, -0.5396317f),
            z = new Vector3(0, 0.5396317f, 0.8419006f)
        }, new Vector3(0, 1.128368f, 0.2776814f));

        public static readonly float DOOR_LIFT_SPEED = 0.01f;
        public static readonly float DOOR_LIFT_AMOUNT = 1f;
        public static readonly float DOOR_ROTATE_SPEED = 0.01f;
        public static readonly float DOOR_ROTATE_AMOUNT = 0.8419006f;
        public static readonly Vector3 DOOR_ELEVATE_AMOUNT = new Vector3(0, 0.5f, -0.4f);
        public static readonly Vector3 DOOR_ELEVATE_SPEED = DOOR_ELEVATE_AMOUNT / 120;



        public override void _Ready()
        {
            doorState = DoorState.CLOSED;
            closedTransform = this.Transform;
            Vector3 liftedOrigin = closedTransform.origin;
            liftedOrigin.y += DOOR_LIFT_AMOUNT;
            liftedTransform = new Transform(closedTransform.basis, liftedOrigin);

            doorLifted = false;
            doorRotated = false;
            doorElevated = false;
        }

        public override void _Process(float delta)
        {
            base._Process(delta);
            if (doorState == DoorState.OPENING)
            {
                TickOpenDoor(delta);
            }
            if (doorState == DoorState.CLOSING)
            {
                TickCloseDoor(delta);
            }
        }

        private void TickOpenDoor(float delta)
        {
            if (!doorLifted)
            {
                TickLiftDoor(delta, true);
                return;
            }
            if (!doorRotated)
            {
                TickRotateDoor(delta);
                return;
            }
            if (!doorElevated)
            {
                TickElevateDoor(delta);
                return;
            }
            //temp
            SetDoorState(DoorState.CLOSING);
        }

        private void TickCloseDoor(float delta)
        {
            if (!doorLifted)
            {
                TickLiftDoor(delta, false);
            }
            SetDoorState(DoorState.CLOSED);
        }

        private void TickLiftDoor(float delta, bool isOpening)
        {
            Vector3 location = this.Transform.origin;
            if (isOpening)
            {
                if (location.y >= (closedTransform.origin.y + 1))
                {
                    this.doorLifted = true;
                    this.Transform = liftedTransform;
                    return;
                }

                location.y += DOOR_LIFT_SPEED;
            }
            else
            {
                if (location.y >= (closedTransform.origin.y))
                {
                    this.doorLifted = true;
                    this.Transform = closedTransform;
                    return;
                }

                location.y -= DOOR_LIFT_SPEED;
            }
            Transform transform = new Transform(this.Transform.basis, location);
            this.Transform = transform;
            if (isOpening)
            {
                if (this.Transform.origin.y >= (closedTransform.origin.y + 1))
                {
                    this.doorLifted = true;
                    this.Transform = closedTransform;
                }
            }
        }

        private void SetDoorState(DoorState state)
        {
            this.doorState = state;
            this.doorLifted = false;
            this.doorRotated = false;
        }

        private void TickRotateDoor(float delta)
        {
            Vector3 xAxis = new Vector3(1, 0, 0);
            Vector3 pivotPoint = new Vector3(0, DOOR_LIFT_AMOUNT * 2, DOOR_LIFT_AMOUNT);
            Vector3 pivotOrigin = liftedTransform.origin;
            Vector3 pivotRadius = pivotOrigin - pivotPoint;
            Transform transform = new Transform(this.Transform.basis, pivotPoint);
            Transform updatedPosition = transform.Rotated(xAxis, -DOOR_ROTATE_SPEED).Translated(pivotRadius);
            this.Transform = updatedPosition;
            if (this.Transform.basis.Column1.y <= DOOR_ROTATE_AMOUNT)
            {
                this.doorRotated = true;
            }
        }

        private void TickElevateDoor(float delta)
        {
            Vector3 origin = this.Transform.origin;
            Vector3 updatedPosition = origin + DOOR_ELEVATE_SPEED;
            Transform transform = new Transform(this.Transform.basis, updatedPosition);
            this.Transform = transform;
            if (this.Transform.origin >= OPEN_TRANSFORM.origin)
            {
                this.doorElevated = true;
                this.Transform = OPEN_TRANSFORM;
            }
        }

        public void CloseDoor(bool animate)
        {
            if (animate)
            {
                doorState = DoorState.CLOSING;
                return;
            }
            this.Transform = this.closedTransform;
            doorState = DoorState.CLOSED;
        }

        public DoorState GetCurrentState()
        {
            return this.doorState;
        }

        public void OpenDoor(bool animate)
        {
            if (animate)
            {
                doorState = DoorState.OPENING;
                return;
            }
            this.Transform = OPEN_TRANSFORM;
            doorState = DoorState.OPEN;
        }
    }
}
