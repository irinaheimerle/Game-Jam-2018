using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroys a GameObject after x seconds once DestroyMe() method is called. 
/// Attach this as a component to any object you wish to be able to destroy.
/// </summary>
public class GameObject_Destroyer : MonoBehaviour {

	public float destroyAfterSeconds = 5f;

	public void DestroyMe(){
		StartCoroutine (run());
	}

	private IEnumerator run(){
		yield return new WaitForSeconds (destroyAfterSeconds);
		GameObject.Destroy (gameObject);
	}
}
