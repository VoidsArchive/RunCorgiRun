using System;
using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;
    public GameTimer GameTimer;
    public Corgi Corgi;
    public Music Music;
    
    public BeerPlacer BeerPlacer;
    public BonePlacer BonePlacer;
    public PillPlacer PillPlacer;
    public MoonshinePlacer MoonshinePlacer;

    private bool isGameRunning = false;
    void Start()
    {
        Ui.HideGameOverScreen();
        Ui.ShowStartScreen();
        Music.PlayMenuMusic();
    }

    public bool isPlaying()
   {
        return isGameRunning;
    }
    
    public void OnStartButtonClicked()
    {
        Ui.HideStartScreen();
        StartGame();
    }

    private void StartGame()
    {
       isGameRunning = true;
        GameTimer.StartTimer(10, OnTimerFinished);
        StartPlacers();
        ScoreKeeper.ResetScore();
        Ui.ResetScore();
        Corgi.Reset();
        Music.PlayGameMusic();

    }

    private void StartPlacers()
    {
        BeerPlacer.StartPlacing();
        BonePlacer.StartPlacing();
        PillPlacer.StartPlacing();
        MoonshinePlacer.StartPlacing();
    }

    private void StopPlacers()
    {
        BeerPlacer.StopPlacing();
        BonePlacer.StopPlacing();
        PillPlacer.StopPlacing();
        MoonshinePlacer.StopPlacing();
    }

    private void OnTimerFinished()
    {
        isGameRunning = false;
        Ui.ShowGameOverScreen();
        StopPlacers();
        Music.PlayMenuMusic();
    }

    private void Update()
    {
        if (isGameRunning)
        {
           Ui.ShowTime(); 
        }
        
    }

    public void OnPlayAgainButtonClicked()
    {
        Ui.HideGameOverScreen();
        StartGame();
    }
}
