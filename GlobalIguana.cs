using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalIguana : MonoBehaviour {

    public static int IguanaType; //1=Night, 2=BW, 3=Different, 4 -Mozaik
    public GameObject TrackWindow;

    public void NightIguana()
    {
        IguanaType = 1;
        TrackWindow.SetActive(true);
    }

    public void BWIguana()
    {
        IguanaType = 2;
        TrackWindow.SetActive(true);
    }

    public void DifIguana()
    {
        IguanaType = 3;
        TrackWindow.SetActive(true);
    }

    public void MozIguana()
    {
        IguanaType = 4;
        TrackWindow.SetActive(true);
    }
}