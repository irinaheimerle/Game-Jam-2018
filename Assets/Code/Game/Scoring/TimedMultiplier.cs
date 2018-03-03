using UnityEngine;
using System.Collections;

/// <summary>
/// Provides a score boost gotten during the duration of this multiplier by its value.
/// Value should not be above 5.0f for realistic values.
/// </summary>
public class TimedMultiplier : Multiplier
{

	public float durationInSeconds = 3.0f;

	private bool _isRunning = false;
	private float _currDuration;

	// Use this for initialization
	void Start()
	{
		_currDuration = durationInSeconds;
	}

	// Update is called once per frame
	void Update()
	{
		if (_isRunning)
		{
			_currDuration -= Time.deltaTime;
			//Debug.Log("CURR: " + _currDuration);
			//if the time is up for this multiplier, announce death
			if (_currDuration <= 0)
			{
				FinishMultiplier();
				_currDuration = 0;
			}
		}
			
	}


	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	public override Multiplier CreateMultiplier(Transform multiplierContainer)
	{
		TimedMultiplier mult = TimedMultiplier.Instantiate(this, multiplierContainer);
		mult.ResumeMultiplier();
		return mult;
	}

	public override void PauseMultiplier()
	{
		_isRunning = false;
		base.PauseMultiplier();
	}

	public override void ResumeMultiplier()
	{
		_isRunning = true;
		base.ResumeMultiplier();
	}

	/// <summary>
	/// Resets the multiplier.  Turns it off as well - resume required.
	/// </summary>
	public override void ResetMultiplier()
	{
		_isRunning = false;
		_currDuration = durationInSeconds;
		base.ResetMultiplier();
	}
	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/


}
