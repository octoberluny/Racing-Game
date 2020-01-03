using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour {

    public GameObject BWButton;
    public GameObject MozButton;
    public int cashValue;

    void Update()
    {
        cashValue = GlobalCash.TotalCash;
        if (cashValue >= 500)
        {
            BWButton.GetComponent<Button>().interactable = true;
        }
        if (cashValue >= 1000)
        {
            MozButton.GetComponent<Button>().interactable = true;
        }
    }

    public void BWUnlock()
    {
        BWButton.SetActive(false);
        cashValue -= 500;
        GlobalCash.TotalCash -= 500;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("BWBought", 500);
    }

    public void MozUnlock()
    {
        BWButton.SetActive(false);
        cashValue -= 1000;
        GlobalCash.TotalCash -= 1000;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("MozBought", 1000);
    }
}