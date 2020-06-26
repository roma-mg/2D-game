using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bank
{
    public Bank (int countMoney)
    {
        _countMoney = countMoney;
    }

    private int _countMoney;

    public void AddMoney (int m)
    {
        _countMoney += m;
        GameObject.Find("Canvas/Bank").GetComponent<Text>().text = _countMoney.ToString();
    }

 
}
