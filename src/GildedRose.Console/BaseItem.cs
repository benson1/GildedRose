using System;

public abstract class BaseItem
{
    public string Name { get; set; }
    public int Sellin { get; set; }
    public int Quality { get; set; }

    public BaseItem()
    {

    }
    public virtual void UpdateItem()
    {
        Sellin -= 1;
        if (Quality > 0) { Quality -= Sellin < 1 ? 2 : 1; };
    }

    //public abstract float UpdateItem();
}
