using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Manages the Score and multipliers.
/// </summary>
public class Score_Manager : MonoBehaviour
{
	private static Score_Manager _instance;

	[Tooltip("The time in seconds that is allowed between multiply interactions before the multiplier disappears.")]
	public float multiplierCooldown = 5.0f;

	private static int _currScore;
	private static float _multiplier;
    private const int _CLICKED_POINTS = 500;

    private static float _currMultiplierCooldown;

	private void Awake()
	{
		_instance = this;
	}

	private void Start()
	{
		_multiplier = 1.0f;
	}

	// Update is called once per frame
	void Update()
	{
		//count down on the cooldown if there is a multiplier to assign
		if (_currMultiplierCooldown > 0.0f)
			_currMultiplierCooldown -= Time.deltaTime;
		else
			_multiplier = 1.0f;
	}


	//TODO: Remove Test case later.
	private void OnGUI()
	{
		if (!Debug_Manager.ShowDebugTools) return;

		GUILayout.BeginArea(new Rect(150, 0, 100, 100));
		if (GUILayout.Button("Test Score Add"))
			AddToScore(1.0f);
		if (GUILayout.Button("Test Multiplier"))
			AddMultiplier(2.0f);
		GUILayout.EndArea();
		GUILayout.BeginArea(new Rect(250, 0, 100, 100));
		GUILayout.Label("Score: " + _currScore);
		GUILayout.EndArea();
	}


	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	/// <summary>
	/// Adds a given number to the score.
	/// </summary>
	/// <param name="score"></param>
	public void AddToScore(float score)
	{
		_currScore += (int)Math.Round(score * _multiplier);
	}
	/// <summary>
	/// Adds a number to the multiplier used on the score.  Will reset the cooldown.
	/// </summary>
	/// <param name="multiplier"></param>
	public void AddMultiplier(float multiplier)
	{
		_multiplier += multiplier;
		//reset cooldown
		_currMultiplierCooldown = multiplierCooldown;
	}

	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/
	public static float CurrentScore { get { return _currScore; } }

    public static void ClickPoints()
    { _currScore += _CLICKED_POINTS; }
}