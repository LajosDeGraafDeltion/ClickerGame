using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSeller : MonoBehaviour
{

    public ItemManager itemM;
    public GameObject sellAutomatic;
    public GameObject autoSellText;
    public GameObject reduceTimer;
    public int AutoSellAmount;
    public int sellUpgrade;
    public float getTimer = 2.5f;

    void Start()
    {
        sellAutomatic.SetActive(false);
        autoSellText.SetActive(false);
        reduceTimer.SetActive(false);
    }


    void Update()
    {
        if (itemM.totalAmount >= 250 && itemM.currency >= 300)
        {
            ShowSellOption();
        }

        if (itemM.totalAmount >= 550 && itemM.currency >= 1000)
        {
            ShowTimeReduce();
        }
    }

    public void ShowSellOption()
    {
        sellAutomatic.SetActive(true);
        autoSellText.SetActive(true);
    }

    public void ShowTimeReduce()
    {
        reduceTimer.SetActive(true);
    }

    public void UpgradeReduceTime()
    {
        getTimer = 0.5f;
        reduceTimer.SetActive(false);
    }

    public IEnumerator SellTimer()
    {
        yield return new WaitForSeconds(getTimer);
        itemM.MinusCurrentAmount();
        StartSell();
    }

    public void StartSell()
    {
        StartCoroutine(SellTimer());
    }
}
