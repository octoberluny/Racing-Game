using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class IguanaControl : MonoBehaviour {

    public GameObject iguanaControl;
    public GameObject Dreamiguana01;

    void Start()
    {
        iguanaControl.GetComponent<IguanaUserController>().enabled = true;
        Dreamiguana01.GetComponent<CarAIControl>().enabled = true;
    }
}
