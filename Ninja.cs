using System;
using System.Collections.Generic;

abstract class Ninja
{
	protected int calorieIntake;
	public List<IConsumable> FoodHistory;
	public abstract bool IsFull { get; set; }
	
	public Ninja()
	{
		calorieIntake = 0;
		FoodHistory = new List<IConsumable>();
	}
	public abstract void Eat(IConsumable item);
}
