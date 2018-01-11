using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

    public int currency;
    public int currentAmount;
    public int totalAmount;
    public int currentValue;

    public void PlusCurrentAmount()
    {
        currentAmount++;
    }

    public void MinusCurrentAmount()
    {
        if(currentAmount > 0)
        {
            currentAmount--;
            currency += currentValue;
        }

    }

    public void TotalAmount()
    {
        totalAmount++;
    }
}
