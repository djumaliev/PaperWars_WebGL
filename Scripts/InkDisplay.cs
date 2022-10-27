using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InkDisplay : MonoBehaviour
{
    [SerializeField] int inks = 10;
    Text inkText;
    float currentInks;

 
    void Start()
    {
        currentInks = ((inks - PlayerPrefsController.GetDifficulty())+1)*1000;
        inkText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("inks setting currently is " + PlayerPrefsController.GetDifficulty());
    }

    private void UpdateDisplay()
    {
        inkText.text = currentInks.ToString();
    }

    public bool HaveEnoughInks(int amount)
    {
        return currentInks >= amount;
    }

    public void AddInks(int amount)
    {
        currentInks += amount;
        UpdateDisplay();
    }

    public void SpendingInks(int amount)
    {
        if (currentInks >= amount)
        {
            currentInks -= amount;
            UpdateDisplay();
        }
    }
}
