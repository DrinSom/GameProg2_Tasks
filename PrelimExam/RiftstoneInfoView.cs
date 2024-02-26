using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RiftstoneInfoView : MonoBehaviour
{
    public Riftstone riftstone;

    [Header("UI Headers")]
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI genderTMP;
    public TextMeshProUGUI hpTMP;
    public TextMeshProUGUI AtkTMP;
    public TextMeshProUGUI DefTMP;
    public TextMeshProUGUI SpAtkTMP;
    public TextMeshProUGUI SpDefTMP;
    public TextMeshProUGUI SpeedTMP;
    public TextMeshProUGUI TypeTMP;


    public void OnEnable()
    {
        DisplayRiftstone(riftstone);
    }
    public void DisplayRiftstone(Riftstone riftstone)
    {
        nameTMP.text = ("Name: " + riftstone.name);
        genderTMP.text = ("Gender: " + riftstone.gender.ToString());
        hpTMP.text = ("Health: " + riftstone.hp.ToString());
        AtkTMP.text = ("Attack: " + riftstone.atk.ToString());
        DefTMP.text = ("Defense: " + riftstone.def.ToString());
        DefTMP.text = ("Defense: " + riftstone.def.ToString());
        SpAtkTMP.text = ("Sp. Attack: " + riftstone.spAtk.ToString());
        SpDefTMP.text = ("Sp. Defense: " + riftstone.spDef.ToString());
        SpeedTMP.text = ("Speed: " + riftstone.speed.ToString());
        TypeTMP.text = ("Type: " + riftstone.riftstoneType.ToString());


    }

    public void ClearView()
    {
        riftstone = null;
        nameTMP.text = null;
        genderTMP.text = null;
        hpTMP.text = null;
        AtkTMP.text = null;
        DefTMP.text = null;
        SpAtkTMP.text = null;
        SpDefTMP.text = null;
        SpeedTMP.text = null;
        TypeTMP.text = null;

    }
    public void OnDisable()
    {
        ClearView();
    }
}
