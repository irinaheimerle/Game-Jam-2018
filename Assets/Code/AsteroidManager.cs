using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {
    List<Asteroid> asteroidList;
    public Asteroid template;

	public GameObject earth;
	public float asteroidShakeMagnitude = 1.0f;

	private float _startingDistance = -1;

	// Use this for initialization
    void Start () {
        asteroidList = new List<Asteroid>();

        Game_Manager.OnStartGame += GameStart;
        Game_Manager.StartGame();
	}

    private void GameStart() {
        CreateAsteroid();
        CreateAsteroid();
        CreateAsteroid();
        CreateAsteroid();
    }

    // Update is called once per frame
    void Update () {
		//get the asteroid at the top of the stack and find the distance
		//between it and the earth
		if (asteroidList.Count > 0)
		{
			float distance = Math.Abs(asteroidList[0].transform.position.y - earth.transform.position.y);
			distance = ((distance - _startingDistance) / 10) * -1;
			StartCoroutine(Camera_Manager.ShakeCamera(0.5f, distance * asteroidShakeMagnitude));
			Debug.Log("DISTANCE: " + distance);
		}
	}

    private void CreateAsteroid() {
        Asteroid newAsteroid = Asteroid.Instantiate(template);
        asteroidList.Add(newAsteroid);

		//set the starting distance
		if (_startingDistance == -1) _startingDistance = newAsteroid.transform.position.y;
    }
}
