using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Handles the progression difficulty of the game and controls any behaviours that need to be altered by difficulty.
/// </summary>
public class Difficulty_Manager : MonoBehaviour
{
	private static int _currDifficulty;

	public float intervalBetweenDifficultyChangeInSeconds = 5.0f;

	// Use this for initialization
	void Start()
	{
		Game_Manager.OnStartGame += GameStart;
		Game_Manager.OnPauseGame += GamePause;
		Game_Manager.OnEndGame += GameEnd;
	}



	// Update is called once per frame
	void Update()
	{

	}

	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	public IEnumerator Run()
	{

		while (Game_Manager.CurrentState == Game_Manager.State.Play)
		{
			_currDifficulty++;

			Debug.Log("UPDATE DIFFICULTY: " + _currDifficulty);

			yield return new WaitForSeconds(intervalBetweenDifficultyChangeInSeconds);
		}


	}

	public void Reset()
	{
		_currDifficulty = 0;
	}
	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	private void GameStart()
	{
		StartCoroutine(Run());
	}

	private void GamePause()
	{
		StopAllCoroutines();
	}

	private void GameEnd()
	{
		StopAllCoroutines();
	}
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/
	public static int CurrentDifficulty { get { return _currDifficulty; } }


}
