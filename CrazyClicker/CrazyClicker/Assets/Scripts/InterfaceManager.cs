using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour {

    public ClickManager cManager;
    public ItemManager iManager;
    public Text current;
    public Text total;
    public Text currency;

	void Update ()
    {
		
	}

    public void AddCurrentUI()
    {
        current.text = iManager.currentAmount.ToString();
    }

    public void AddTotalUI()
    {
        total.text = iManager.totalAmount.ToString();
    }

    public void UpdateCurrency()
    {
        currency.text = iManager.currency.ToString();
    }


}
