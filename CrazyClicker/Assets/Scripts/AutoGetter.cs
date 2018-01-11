using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoGetter : MonoBehaviour {

    public ItemManager itemM;
    public SpawnIcon spawnDiamond;
    public GameObject buyAutomatic;
    public GameObject automaterText;
    public GameObject reduceAutoTimer;
    public int autoGetterAmount;
    public int buyUpgrade;
    public float currentTimer = 2.5f;

	void Start ()
    {
        buyAutomatic.SetActive(false);
        automaterText.SetActive(false);
        reduceAutoTimer.SetActive(false);
    }
	

	void Update ()
    {
        if (itemM.totalAmount >= 10 && itemM.currency >= 100)
        {
            ShowAutoGet();
        }

        if (itemM.totalAmount >= 350 && itemM.currency >= 550)
        {
            ShowAutoReduceTimer();
        }
    }

    public void ShowAutoReduceTimer()
    {
        reduceAutoTimer.SetActive(true);
    }

    public void UpgradeReduceBuyTimer()
    {
        currentTimer = 0.5f;
        reduceAutoTimer.SetActive(false);
    }

    public void ShowAutoGet()
    {
        buyAutomatic.SetActive(true);
        automaterText.SetActive(true);
    }

    public IEnumerator AutoTimer()
    {
        yield return new WaitForSeconds(currentTimer);
        itemM.currentAmount += 1;
        itemM.totalAmount += 1;
        spawnDiamond.SpawnDiamond();
        StartTimer();
    }

    public void StartTimer()
    {
        StartCoroutine(AutoTimer());
    }

}
