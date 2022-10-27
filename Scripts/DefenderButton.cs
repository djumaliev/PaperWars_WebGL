using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    private void Start()
    {
        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if (!costText)
        {
            Debug.LogError(name + " has no cost, add some!");
        }
        else
        {
            costText.text = defenderPrefab.GetInkCost().ToString();
        }
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 70);
        }

        GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);

        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
