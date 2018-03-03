using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
	public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);

	}

	//quit function
	public void ExitOnClick()
	{
		Application.Quit();
	}
}
