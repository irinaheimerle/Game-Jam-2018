﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Manages Game States and time played.
/// </summary>
public class Game_Manager : MonoBehaviour
{
    public delegate void Game_Event();
    public static Game_Event OnStartGame, OnPauseGame, OnEndGame;

    public enum State
    {
        Play,
        Pause,
        Game_Over
    }

    private static Game_Manager _instance;
    private static State _currentState;
    private static string time;
    private static float _totalTime;


    private void Awake()
    {
        _instance = this;
    }

    // Use this for initialization
    void Start()
    {
        StartGame();

    }

    // Update is called once per frame
    void Update()
    {

        if (_currentState == State.Play)
            _totalTime += Time.deltaTime;

        ///im testing this i will move it out later i hope
        int minutes = Mathf.FloorToInt(_totalTime / 60F);
        int seconds = Mathf.FloorToInt(_totalTime - minutes * 60);

        string time = string.Format("{0:0}:{1:00}", minutes, seconds);

    }

   

    //TODO: Remove on testing complete.
    private void OnGUI()
    {
        if (!Debug_Manager.ShowDebugTools) return;

        if (GUILayout.Button("Start Game"))
            StartGame();
        if (GUILayout.Button("End Game"))
            EndGame();
    }

    /*--------------------------------------------------------------------------------METHODS-----------------------*/
    public static void StartGame()
    {
        if (OnStartGame != null)
            OnStartGame();

        _currentState = State.Play;

        Time.timeScale = 1f;

        Debug.Log("I'm actually unpaused!");
    }

    public static void PauseGame()
    {
        if (OnPauseGame != null)
            OnPauseGame();



        _currentState = State.Pause;

        Debug.Log("I'm actually working!");

        Time.timeScale = 0f;
    }

    public static void EndGame()
    {
        if (OnEndGame != null)
            OnEndGame();

        _currentState = State.Game_Over;
    }



    /// <summary>
    /// Changes the state of the game.
    /// </summary>
    /// <param name="state">State.</param>
    public static void ChangeState(State state)
    {
        _currentState = state;
    }
    /*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
    /*--------------------------------------------------------------------------------EVENTS------------------------*/
    /*--------------------------------------------------------------------------------OVERRIDES---------------------*/
    /*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/
    public static Game_Manager Instance { get { return _instance; } }
    public static State CurrentState { get { return _currentState; } }
    public static string GetTime { get { return time; } }

   
}