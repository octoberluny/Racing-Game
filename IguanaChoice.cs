using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaChoice : MonoBehaviour {

    //1=Night, 2=BW, 3=Different, 4 -Mozaik
    public GameObject NightBody;
    public GameObject BWBody;
    public GameObject DifBody;
    public GameObject MozBody;

    public GameObject LapTimeManagerN;
    public GameObject HalfPointTriggerN;
    public GameObject CountdownManagerN;

    public GameObject LapTimeManagerBW;
    public GameObject HalfPointTriggerBW;
    public GameObject CountdownManagerBW;

    public GameObject LapTimeManagerD;
    public GameObject HalfPointTriggerD;
    public GameObject CountdownManagerD;

    public GameObject LapTimeManagerM;
    public GameObject HalfPointTriggerM;
    public GameObject CountdownManagerM;

    public int IguanaImport;

    void Start()
    {
        IguanaImport = GlobalIguana.IguanaType;
        if (IguanaImport == 1)
        {
            NightBody.SetActive(true);
            LapTimeManagerN.SetActive(true);
            HalfPointTriggerN.SetActive(true);
            CountdownManagerN.SetActive(true);
        }

        if (IguanaImport == 2)
        {
            BWBody.SetActive(true);
            LapTimeManagerBW.SetActive(true);
            HalfPointTriggerBW.SetActive(true);
            CountdownManagerBW.SetActive(true);
        }

        if (IguanaImport == 3)
        {
            DifBody.SetActive(true);
            LapTimeManagerD.SetActive(true);
            HalfPointTriggerD.SetActive(true);
            CountdownManagerD.SetActive(true);
        }

        if (IguanaImport == 4)
        {
            MozBody.SetActive(true);
            LapTimeManagerM.SetActive(true);
            HalfPointTriggerM.SetActive(true);
            CountdownManagerM.SetActive(true);
        }
    }

}