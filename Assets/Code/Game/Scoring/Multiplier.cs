using UnityEngine;
using System.Collections;

public class Multiplier : MonoBehaviour
{
	public delegate void Multiplier_Event(Multiplier multiplier);
	public Multiplier_Event OnFinish;

	public string name = "";
	public int value;

	private void Start()
	{
		
	}

	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	public virtual Multiplier CreateMultiplier(Transform multiplierContainer)
	{
		return Multiplier.Instantiate(this, multiplierContainer);
	}

	public virtual void PauseMultiplier() { }

	public virtual void ResumeMultiplier() { }

	public virtual void ResetMultiplier() { }

	/*-------Event Callers-------*/
	protected void FinishMultiplier()
	{
		if (OnFinish != null)
			OnFinish(this);
	}
	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/
}
