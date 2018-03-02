using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{

	public Multiplier testMultiplier;
	public Transform multiplierContainer;

	private static int _currScore;
	private static List<Multiplier> _multipliers;

	// Use this for initialization
	void Start()
	{
		AddMultiplier(testMultiplier);
	}

	// Update is called once per frame
	void Update()
	{

	}


	//TODO: Remove Test case later.
	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(150, 0, 100, 100));
		if (GUILayout.Button("Test Multiplier"))
			AddMultiplier(testMultiplier);
		GUILayout.EndArea();
	}


	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	public void AddMultiplier(Multiplier multiplier)
	{
		Debug.Log("ADD MULT");
		//create a copy
		Multiplier mult = multiplier.CreateMultiplier(multiplierContainer);
		//add multiplier
		_multipliers.Add(mult);
		//listen to multiplier
		mult.OnFinish += OnMultiplierFinish;

		Debug.Log("START MULT");

	}

	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	private void OnMultiplierFinish(Multiplier multiplier)
	{
		//remove the listener
		multiplier.OnFinish -= OnMultiplierFinish;

		//remove the multiplier
		if (_multipliers.Contains(multiplier))
			_multipliers.Remove(multiplier);

		//destroy the object
		Multiplier.DestroyImmediate(multiplier);

		Debug.Log("END MULT");
	}
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/
	public static int CurrentScore { get { return _currScore; } }


}