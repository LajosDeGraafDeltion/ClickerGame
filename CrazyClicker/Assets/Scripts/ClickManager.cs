using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{

    public ItemManager itemM;
    public InterfaceManager interfaceManager;
    public SpawnIcon spawnDiamond;
    public AutoGetter autoGet;
    public AutoSeller autoSell;
    public Animator gainedAnim;
    public GameObject diamondGain;

    void Start()
    {
        diamondGain.SetActive(false);
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            itemM.totalAmount += 100;
            itemM.currentAmount += 100;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            itemM.currency += 100;
            itemM.currentAmount -= 100;
        }
    }

    public void AddItem()
    {
        itemM.PlusCurrentAmount();
        itemM.TotalAmount();
        diamondGain.SetActive(true);
        gainedAnim.SetTrigger("ButtonPress");
        spawnDiamond.SpawnDiamond();
    }

    public void SellItem()
    {
        itemM.MinusCurrentAmount();
    }

    public void BoughtAutomatic()
    {
        if (itemM.currency >= 100)
        {
            itemM.currency -= 100;
            autoGet.autoGetterAmount++;
            autoGet.StartTimer();
        }
    }

    public void SellAutomatic()
    {
        if (itemM.currency >= 300)
        {
            itemM.currency -= 300;
            autoSell.AutoSellAmount++;
            print(autoSell.AutoSellAmount);
            autoSell.StartSell();
        }
    }

    public void UpgradeBuyer()
    {
        if (itemM.currency >= 550)
        {
            itemM.currency -= 550;
            autoGet.UpgradeReduceBuyTimer();
        }
    }
    
    public void UpgradeSeller()
    {
        if (itemM.currency >= 1000)
        {
            itemM.currency -= 1000;
            autoSell.UpgradeReduceTime();
        }
    }
}