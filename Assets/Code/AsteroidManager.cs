using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {
    List<Asteroid> asteroidList;
    public Asteroid template;
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
		
	}

    private void CreateAsteroid() {
        Asteroid newAsteroid = Asteroid.Instantiate(template);
        asteroidList.Add(newAsteroid);
    }
}
