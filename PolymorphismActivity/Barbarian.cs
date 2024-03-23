using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Barbarian : Swordsman
    {
       public override void Class()
        {
            base.Class();
            Debug.Log("2nd Job: Barbarian");
        }
    }