using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

    public GameObject MyIguana;
    public GameObject AIIguana;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;
    public GameObject LapTime;
    public GameObject positionDisplay;
    public GameObject LapDisplay;

    void OnTriggerEnter()
    {
        if (ModeTime.isTimeMode == true)
        {
            //we are on the race mode
        }
        else
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MyIguana.SetActive(false);
            CompleteTrig.SetActive(false);

            IguanaCharacter.uskor = 0.0f;
            MyIguana.GetComponent<IguanaCharacter>().enabled = false;
            MyIguana.GetComponent<IguanaUserController>().enabled = false;
            MyIguana.SetActive(true);

            CarController.m_Topspeed = 0.0f;
            AIIguana.GetComponent<CarController>().enabled = false;
            AIIguana.GetComponent<CarAIControl>().enabled = false;
            //AIIguana.GetComponent<CarAIControl>().iguanaAnim.SetFloat("Idle", 1);
            
            AIIguana.SetActive(true);

            FinishCam.SetActive(true);
            LevelMusic.SetActive(false);
            ViewModes.SetActive(false);
            FinishMusic.Play();
            StartCoroutine(CreditEnd());
            LapTime.SetActive(false);
            LapDisplay.GetComponent<Text>().text = "2";

            if (positionDisplay.GetComponent<Text>().text == "1st Place")
            {
                GlobalCash.TotalCash += 100;
                PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
                positionDisplay.GetComponent<Text>().text = "WIN!";
            }
            if (positionDisplay.GetComponent<Text>().text == "2nd Place")
            {
                GlobalCash.TotalCash -= 50;
                PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
                positionDisplay.GetComponent<Text>().text = "Lose...";
            }

        }

    }
    IEnumerator CreditEnd()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);
    }

}