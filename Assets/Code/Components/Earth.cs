using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {

	public ParticleSystem impactPart;

	public void AsteroidHit(Vector3 pos){
		ParticleSystem cloneImpact = ParticleSystem.Instantiate(impactPart);
		cloneImpact.transform.position = pos;

		GameObject.Destroy (impactPart);

		cloneImpact.GetComponent<GameObject_Destroyer> ().DestroyMe ();
			
		

	}
}
