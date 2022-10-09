using CyberRPG.World.Vehicles.Car.BasicCar.Door;
using Godot;
using System;

namespace CyberRPG.World.Vehicles.Car.BasicCar
{ 

public class BasicCar : Spatial, ICar
{

	private PassengerFrontDoor passengerFrontDoor;

	public override void _Ready()
	{
		this.passengerFrontDoor = this.GetNode<PassengerFrontDoor>("Body/PassengersFrontDoor");
		this.passengerFrontDoor.OpenDoor(true);
	}
}
}
