using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int HP { get; private set; }
    public int Attack { get; private set; }
    public int Shield { get; private set; }
    public int Critical { get; private set; }
    public string Job { get; private set; }
    public string JobExplain { get; private set; }
    public List<Item> Inventory { get; private set; } = new List<Item>();

    public Character(string name, int level, int hp, int attack, int shield, int critical, string job, string jobExplain)
    {
        Name = name;
        Level = level;
        HP = hp;
        Attack = attack;
        Shield = shield;
        Critical = critical;
        Job = job;
        JobExplain = jobExplain;
    }
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void EquipItem(Item item)
    {
        item.Equip();
    }

    public void UnEquipItem(Item item)
    {
        item.UnEquip();
    }

}
