using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTime : MonoBehaviour {

    public int ModeSelection;
    public GameObject AIIguana;

    public static bool isTimeMode = false;

    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if (ModeSelection == 2)
        {
            isTimeMode = true;
            AIIguana.SetActive(false);
        }

    }
}