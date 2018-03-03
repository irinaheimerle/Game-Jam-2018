using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Click_Destroyer : MonoBehaviour {

	public ParticleSystem destroyPart;

	void Start(){
		destroyPart.enableEmission = false;
	}

	private void OnMouseDown(){

		destroyPart.enableEmission = true;
		ParticleSystem cloneDestroy = ParticleSystem.Instantiate (destroyPart);

		GameObject.Destroy (destroyPart);
		Vector3 desiredPostion = transform.position;

		cloneDestroy.transform.position = desiredPostion;

		cloneDestroy.GetComponent<GameObject_Destroyer> ().DestroyMe ();
	}
}
