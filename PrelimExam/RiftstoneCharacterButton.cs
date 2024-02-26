using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RiftstoneCharacterButton : MonoBehaviour
{
    public TextMeshProUGUI RiftStoneNameTxt;
    public Image charImage;
    public Image spriteType;

    public void SetRiftstoneData(Riftstone unit)
    {
        RiftStoneNameTxt.text = unit.name;
        charImage.sprite = unit.charSprite;
        spriteType.sprite = unit.spriteType;


    }
}