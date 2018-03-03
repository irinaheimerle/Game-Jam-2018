using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Click_Destroyer : MonoBehaviour {

	public ParticleSystem destroyPart;

	private void Start()
	{
		destroyPart.enableEmission = false;
	}

	private void OnMouseDown(){
		ParticleSystem cloneDestroy = ParticleSystem.Instantiate (destroyPart);

		cloneDestroy.enableEmission = true;

		GameObject.Destroy (destroyPart);
		Vector3 desiredPostion = transform.position;

		cloneDestroy.transform.position = desiredPostion;

		cloneDestroy.GetComponent<GameObject_Destroyer> ().DestroyMe ();
	}
}
