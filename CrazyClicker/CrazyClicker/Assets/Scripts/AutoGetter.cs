using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoGetter : MonoBehaviour {

    public ItemManager itemM;
    public GameObject buyAutomatic;

	void Start ()
    {
        buyAutomatic.SetActive(false);
    }
	

	void Update ()
    {
		if(itemM.totalAmount >= 100 && itemM.currency >= 150)
        {
            ShowAutoGet();
        }
	}

    public void ShowAutoGet()
    {
        buyAutomatic.SetActive(true);
    }

    public void BoughtAutomatic()
    {

    }
}
