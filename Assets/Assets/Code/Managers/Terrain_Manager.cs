using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages Terrain status.
/// </summary>
public class Terrain_Manager : MonoBehaviour {

	public enum State 
	{
		Full,
		Mid,
		Dead
	}

	private static Terrain_Manager _instance;

	[SerializeField]
	private GameObject _terrainFull;
	[SerializeField]
	private GameObject _terrainMid;
	[SerializeField]
	private GameObject _terrainDead;

	private static State _currentState;
	private static GameObject _currTerrain;

	private void Awake()
	{
		_instance = this;
	}

	private void Start()
	{
		_terrainFull.SetActive(false);
		_terrainMid.SetActive(false);
		_terrainDead.SetActive(false);
		ChangeState (State.Full);
	}


	/*TODO: Remove test from end.*/
	private void OnGUI()
	{
		if (!Debug_Manager.ShowDebugTools) return;


		GUILayout.BeginArea (new Rect (0, 50, 250, 450));
		if (GUILayout.Button ("Change To Full Terrain"))
			ChangeState (State.Full);
		if (GUILayout.Button ("Change To Mid Terrain"))
			ChangeState (State.Mid);
		if (GUILayout.Button ("Change To Dead Terrain"))
			ChangeState (State.Dead);
		GUILayout.EndArea ();
	}


	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	/// <summary>
	/// Changes the state of the terrain.
	/// </summary>
	/// <param name="state">State.</param>
	public static void ChangeState(State state)
	{
		_currentState = state;
		//turn off last terrain
		if (_currTerrain != null)
			_currTerrain.SetActive (false);


		//set the new terrain
		switch (_currentState) 
		{
		case State.Full:
			_currTerrain = _instance._terrainFull;
			break;
		case State.Mid:
			_currTerrain = _instance._terrainMid;
			break;
		case State.Dead:
			_currTerrain = _instance._terrainDead;
			break;
		}

		//show new terrain
		_currTerrain.SetActive (true);
	}
	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/


}
