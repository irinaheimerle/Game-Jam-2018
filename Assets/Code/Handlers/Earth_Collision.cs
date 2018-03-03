using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth_Collision : MonoBehaviour {

	public Earth earth;

	private void OnCollisionEnter(Collision col){
		//when an asteroid hits the earth, this will give the location
		earth.AsteroidHit (col.gameObject);
	}


}
