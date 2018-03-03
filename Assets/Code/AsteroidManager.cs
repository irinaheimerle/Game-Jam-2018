using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {
    List<Asteroid> asteroidList;
    public Asteroid template;

    private static AsteroidManager instance;

	public GameObject earth;
	public float asteroidShakeMagnitude = 1.0f;

	private float _startingDistance = -1;
    private int waveCounter;


    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        asteroidList = new List<Asteroid>();
        waveCounter = 5;

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
			//float distance = Math.Abs(asteroidList[0].transform.position.y - earth.transform.position.y);
			//distance = ((distance - _startingDistance) / 10) * -1;
			//StartCoroutine(Camera_Manager.ShakeCamera(0.5f, distance * asteroidShakeMagnitude));
			//Debug.Log("DISTANCE: " + distance);
		}

        //Debug.Log(asteroidList.Count);

        if (asteroidList.Count <= 1 )
        {
            for (int i=0; i < waveCounter; i++)
            {

                CreateAsteroid();
                
            }
            waveCounter++;
        }
    }

    private void CreateAsteroid() {
        Asteroid newAsteroid = Asteroid.Instantiate(template);
        asteroidList.Add(newAsteroid);

		//set the starting distance
		if (_startingDistance == -1) _startingDistance = newAsteroid.transform.position.y;
    }

    public static void DestroyAsteroid(Asteroid asteroid)
    {
        instance.asteroidList.Remove(asteroid);
        GameObject.DestroyImmediate(asteroid.gameObject);
        
    }
}
