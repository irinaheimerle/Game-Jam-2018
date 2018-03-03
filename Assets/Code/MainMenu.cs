using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    //properties for timer
    public Text txtTimer;
    public float countSeconds;
    private int countMin;
    

    private void Update()
    {
        UpdateTimerUI();
    }

    public void LoadByIndex(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);

    }

    //quit function
    public void ExitOnClick() {
        Application.Quit();
    }

    //update timer!
    public void UpdateTimerUI() {
        countSeconds += Time.deltaTime;
        //txtTimer.text = countMin + "m" + (int)countSeconds + "s";

        if (countSeconds >= 60) {
            countMin++;
            countSeconds = 0;
        }


       

    }




}
