using UnityEngine;

public class Item
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Sprite Icon { get; private set; }

    public Item(string name, string description, Sprite icon)
    {
        Name = name;
        Description = description;
        Icon = icon;
    }
}
