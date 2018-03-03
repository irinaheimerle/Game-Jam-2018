using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {

	public ParticleSystem impactPart;

	public void AsteroidHit(GameObject hit){
		ParticleSystem cloneImpact = ParticleSystem.Instantiate(impactPart);
		cloneImpact.transform.position = hit.transform.position;

		cloneImpact.GetComponent<GameObject_Destroyer> ().DestroyMe ();
		hit.GetComponent<GameObject_Destroyer>().DestroyMe();	
	}
}
