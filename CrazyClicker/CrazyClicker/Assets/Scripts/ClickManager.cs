using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

    public ItemManager itemM;
    public InterfaceManager interfaceManager;

	void Start ()
    {
		
	}
	

	void Update ()
    {

	}

    public void AddItem()
    {
        itemM.PlusCurrentAmount();
        itemM.TotalAmount();
        interfaceManager.AddCurrentUI();
        interfaceManager.AddTotalUI();
    }

    public void SellItem()
    {
        itemM.MinusCurrentAmount();
        interfaceManager.AddCurrentUI();
        interfaceManager.UpdateCurrency();
    }
}
