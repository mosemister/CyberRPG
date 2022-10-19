using System;
using CyberRPG.Vehicle.Car;
using CyberRPG.Vehicle.Car.Basic;
using Godot;

namespace CyberRPG.Vehicle.Car.Basic
{

	public class BasicCar : Spatial, ICar
	{

		private PassengerFrontDoor passengerFrontDoor;

		public override void _Ready()
		{
			this.passengerFrontDoor = this.GetNode<PassengerFrontDoor>("Body/PassengersFrontDoor");
		}
	}
}
