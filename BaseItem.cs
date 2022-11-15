using System;

public abstract class BaseItem
{
    public const string Name { get; set; }
    public string Sellin { get; set; }
    public string Quality { get; set; }
    public virtual void UpdateItem()
    {

    };

    //public abstract float UpdateItem();
}
