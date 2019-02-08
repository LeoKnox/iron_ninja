using System;
using System.Collections.Generic;

class Buffet
{
	public List<Food> Menu;
	
	public Buffet()
	{
		/*Menu = new List<Food>()
		{
			//new Food("Hotdog Sushi", 600, false, false);
		};*/
		Food item1 = new Food("Hotdog Sushi", 600, false, false);
		Food item2 = new Food("Pretzel Sushi", 400, false, false);
		Food item3 = new Food("Pickle Sushi", 300, false, false);
		Food item4 = new Food("Peanut Butter Sushi", 333, false, false);
		Food item5 = new Food("Coffee Bean Sushi", 224, false, false);
		Food item6 = new Food("Chocolate Sushi", 660, false, false);
		Food item7 = new Food("Bunny Rabbit Sushi", 543, false, false);
		Menu.Add(item1);
		Menu.Add(item2);
		Menu.Add(item3);
		Menu.Add(item4);
		Menu.Add(item5);
		Menu.Add(item6);
		Menu.Add(item7);
	}
	
	public Buffet(Food _Food)
	{
		Menu.Add(_Food);
	}
	
	public Food Serve()
	{
		Random rand = new Random();
		int x = rand.Next(0,Menu.Count);
		return(Menu[x]);
	}
}
