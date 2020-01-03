using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour {

    public int BWSelect;
    public int MozSelect;
    public GameObject fakeBW;
    public GameObject fakeMoz;

    public GameObject BWCost;                                                                                                                                                                                                 
    public GameObject MozCost;

    void Start()
    {
        BWSelect = PlayerPrefs.GetInt("BWBought");
        if (BWSelect == 500)
        {
            fakeBW.SetActive(false);
            BWCost.SetActive(false);

        }

        MozSelect = PlayerPrefs.GetInt("MozBought");
        if (MozSelect == 1000)
        {
            fakeMoz.SetActive(false);
            MozCost.SetActive(false);
        }
    }
}