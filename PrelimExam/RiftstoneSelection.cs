using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RiftstoneSelection : MonoBehaviour
{
    public RiftstoneManager riftstoneManager;
    public Transform parentPos;
    public GameObject riftstoneButtonPrefab;
    public RiftstoneInfoView riftstoneInfoView;
    public GameObject dispChanel;

    void Start()
    {
        Debug.Log(riftstoneManager.riftstones.Count());
        foreach (Riftstone r in riftstoneManager.riftstones)
        {
            GameObject buttonPrefab = Instantiate(riftstoneButtonPrefab, parentPos);
            RiftstoneCharacterButton riftstoneButton = buttonPrefab.GetComponent<RiftstoneCharacterButton>();

            riftstoneButton.SetRiftstoneData(r);
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => dispChanel.SetActive(true));
            button.onClick.AddListener(() => riftstoneInfoView.DisplayRiftstone(r));

        }

    }
}