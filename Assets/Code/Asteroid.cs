using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    public GameObject asteroid;
    public Renderer asteroidBounds;
   

	// Use this for initialization
	void Awake () {

        

        Vector3 boundsMax = asteroidBounds.bounds.max;
        Vector3 boundsmin = asteroidBounds.bounds.min;

        Debug.Log("THe Max Bounds is: " + boundsMax + " The Min Bounds is: " + boundsmin);

        //float x = Random.Range(3.4f, 53.5f);
        //float y = Random.Range(250f, 251f);
        //float z = Random.Range(-215f, 275f);

        float x = Random.Range(-175f, 182f);
        float y = Random.Range(100f, 120f);
        float z = Random.Range(-205f, 145f);


        transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update () {
        float x = asteroid.transform.position.x;
        float y = asteroid.transform.position.y;
        float z = asteroid.transform.position.z;
        asteroid.transform.position = new Vector3(x, y-0.2f, z);
	}

    private void OnMouseDown()
    {
        //Debug.Log("I am here");
        //GetComponent<Renderer>().enabled = false;
        AsteroidManager.DestroyAsteroid(this);
        Score_Manager.ClickPoints();
    }
}
