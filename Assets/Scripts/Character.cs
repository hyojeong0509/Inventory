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


    public Character(string name, int level, int hp, int attack, int shield, int critical)
    {
        Name = name;
        Level = level;
        HP = hp;
        Attack = attack;
        Shield = shield;
        Critical = critical;
    }
}
