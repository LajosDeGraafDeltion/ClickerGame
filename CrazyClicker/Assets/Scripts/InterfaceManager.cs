using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour {

    public static InterfaceManager instance;
    public ClickManager cManager;
    public ItemManager iManager;
    public AutoGetter autoGetter;
    public AutoSeller autoSeller;
    public Text current;
    public Text total;
    public Text currency;
    public Text automater;
    public Text automateSell;
    public Text UpgradeSell;
    public Text UpgradeBuy;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Update ()
    {
        AddTotalUI();
        AddCurrentUI();
        UpdateCurrency();
        AddAutoGetter();
        AddAutoSeller();
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

    public void AddAutoGetter()
    {
        print(autoGetter.autoGetterAmount);
        automater.text = autoGetter.autoGetterAmount.ToString();
        print(autoGetter.autoGetterAmount);
    }

    public void AddAutoSeller()
    {
        automateSell.text = autoSeller.AutoSellAmount.ToString();
    }
}
