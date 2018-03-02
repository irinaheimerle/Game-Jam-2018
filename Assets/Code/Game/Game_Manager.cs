using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour {
	public delegate void Game_Event();
	public static Game_Event OnStartGame, OnPauseGame, OnEndGame;
	
	public enum State
	{
		Play,
		Pause,
		Game_Over
	}

	private static Game_Manager _instance;
	private static State _currentState;

	private static bool _isRunning = false;
	private static float _totalTime;


	private void Awake() {
		_instance = this;
	}

	// Use this for initialization
	void Start () {
		StartGame ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if(_isRunning)
			_totalTime += Time.deltaTime;

		//Debug.Log (_totalTime);
	}



	/*-----TEST----------*/
	private void OnGUI()
	{
		if (GUILayout.Button ("Start Game"))
			StartGame ();
		if (GUILayout.Button ("End Game"))
			EndGame ();
	}

	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	public static void StartGame()
	{
		if (OnStartGame != null)
			OnStartGame ();

		_isRunning = true;
	}

	public static void PauseGame()
	{
		if (OnPauseGame != null)
			OnPauseGame ();

		_isRunning = false;
	}

	public static void EndGame()
	{
		if (OnEndGame != null)
			OnEndGame ();

		_isRunning = false;
	}

	/// <summary>
	/// Changes the state of the game.
	/// </summary>
	/// <param name="state">State.</param>
	public static void ChangeState(State state)
	{
		_currentState = state;
	}
	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/
	public static Game_Manager Instance { get { return _instance; } }
	public static State CurrentState { get { return _currentState; } }

}
