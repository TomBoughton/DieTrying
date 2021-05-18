using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData
{
    public int level;
    public int attack;
    public int defence;
    public int tolerance;
    public int mana;
    public int health;
    public int xp;
    public int skillpoints;
    public string scene;
    public bool haveCat;
    public PlayerData (Stats stats)
    {
        level = stats.Level;
        attack = stats.Attack;
        defence = stats.Defence;
        tolerance = stats.Tolerance;
        mana = stats.Mana;
        health = stats.Health;
        xp = stats.Exp;
        skillpoints = stats.SkillPoints;
        scene = stats.scene;
        haveCat = stats.haveCat;
        
    }
}
