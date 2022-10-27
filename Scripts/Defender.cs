using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int inkCost = 100;

    public int GetInkCost()
    {
        return inkCost;
    }


    public void AddInks(int amount)
    {
        FindObjectOfType<InkDisplay>().AddInks(amount);
    }
}
