using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    public GameObject asteroid;

	// Use this for initialization
	void Awake () {
        
        float x = Random.Range(3.4f, 53.5f);
        float y = Random.Range(250f, 251f);
        float z = Random.Range(-215f, 275f);


        transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update () {
        float x = asteroid.transform.position.x;
        float y = asteroid.transform.position.y;
        float z = asteroid.transform.position.z;
        asteroid.transform.position = new Vector3(x, y-0.6f, z);
	}

    private void OnMouseDown()
    {
        //GetComponent<Renderer>().enabled = false;
        GameObject.DestroyImmediate(gameObject);
    }
}
