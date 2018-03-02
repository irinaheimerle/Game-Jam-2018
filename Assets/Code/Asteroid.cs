using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    public GameObject asteroid;

	// Use this for initialization
	void Awake () {
        
        float x = Random.Range(5.0f, 40.0f);
        float y = Random.Range(40.0f, 50.0f);

        Debug.Log("I am x" + x);
        Debug.Log("I am Y" + y);

        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update () {
        float x = asteroid.transform.position.x;
        float y = asteroid.transform.position.y;
        float z = asteroid.transform.position.z;
        asteroid.transform.position = new Vector3(x, y-0.2f, 0);
	}
}
