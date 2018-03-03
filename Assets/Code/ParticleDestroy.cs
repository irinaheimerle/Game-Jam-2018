using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour {

	public void DestroyMe(){
		StartCoroutine (run());
	}

	private IEnumerator run(){
		yield return new WaitForSeconds (5);
		GameObject.Destroy (gameObject);
	}
}
