using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomGame : MonoBehaviour {

    public static int IguanaType;
    public int chooseIguana;

    public static int RaceMode;
    public int chooseMode;

    //public static int RaceMode;
    public int chooseTrack;

    void Start()
    {
        chooseIguana = Random.Range(1, 2);
        chooseMode = Random.Range(0, 2);
        chooseTrack = Random.Range(2, 3);
    }

    public void ChooseIguana()
    {
        IguanaType = chooseIguana;
        RaceMode = chooseMode;
        SceneManager.LoadScene(chooseTrack);
        //TrackWindow.SetActive(true);
    }
    
}