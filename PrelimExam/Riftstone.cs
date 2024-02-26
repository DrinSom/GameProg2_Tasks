using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "Riftstone", menuName ="ScriptableObjects/Riftstone")]
public class Riftstone : ScriptableObject
{
    // Common attributes for all Riftstones
    public string name;
    public Sprite charSprite;
    public Sprite spriteType;
    public int level;
    public Gender gender;
    public int hp;
    public int def;
    public int atk;
    public int spAtk;
    public int spDef;
    public int speed;
    public RiftstoneType riftstoneType;
    public string description;
    public Moves[] moves;

    // Common behavior for all Riftstones
    public void Attack()
    {
        Debug.Log($"{name} used Tackle!");
    }

    
}