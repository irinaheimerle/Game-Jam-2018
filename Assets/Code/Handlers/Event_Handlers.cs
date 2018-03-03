using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Event_Handlers : MonoBehaviour {



    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toPause() {
        Debug.Log("I'm paused!");
        Game_Manager.PauseGame();
        Debug.Log("I'm paused again!");
    }

    public void toResume(){
        Debug.Log("I'm unpaused!");
        Game_Manager.PlayGame();
        Debug.Log("I'm unpaused again!");
    }


}
