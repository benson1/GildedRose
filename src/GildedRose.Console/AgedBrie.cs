using System;

public class AgedBrie : BaseItem
{
	
	public AgedBrie()
	{
		Name = "Aged Brie";
	}

	public override void UpdateItem()
	{
		Sellin -=1;
		Quality = Quality < 50? Quality + 1:50;

	}
}
