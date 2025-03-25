using UnityEngine;

public class Item
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Sprite Icon { get; private set; }

    //-----------------------------------------
    public int Attack { get; private set; }
    public bool IsEquipped { get; private set; }

    public Item(string name, string description, Sprite icon, int attack)
    {
        Name = name;
        Description = description;
        Icon = icon;
        Attack = attack;
        IsEquipped = false;
    }

    public void Equip()
    {
        IsEquipped = true;
    }

    public void UnEquip()
    {
        IsEquipped = false;
    }
    public void ToggleEquip()
    {
        IsEquipped = !IsEquipped;
    }
}
