using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroyed : MonoBehaviour {

	public ParticleSystem destroyPart;

	private void OnMouseDown(){
		ParticleSystem cloneDestroy = ParticleSystem.Instantiate (destroyPart);

		GameObject.Destroy (destroyPart);
		Vector3 desiredPostion = transform.position;

		cloneDestroy.transform.position = desiredPostion;

		cloneDestroy.GetComponent<ParticleDestroy> ().DestroyMe ();
	}
}
