using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiftstoneManager : MonoBehaviour
{
    public Riftstone[] riftstones;
    private string folderPath = "Riftstone"; // Folder name inside the Assets/Resources folder

    void Awake()
    {
        riftstones = Resources.LoadAll<Riftstone>(folderPath);
    }
}