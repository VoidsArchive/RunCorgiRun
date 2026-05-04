using System;
using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;
    public GameTimer GameTimer;
    
    void Start()
    {
        Ui.HideGameOverScreen();
        Ui.ShowStartScreen();
    }

    public bool isPlaying()
    {
        //return isGameRunning;
    }
    
    public void init
    
    public void OnStartButtonClicked()
    {
        Ui.HideStartScreen();
        StartGame();
    }

    private void StartGame()
    {
        GameTimer.StartTimer(10, OnTimerFinished);
    }

    private void OnTimerFinished()
    {
        Ui.ShowGameOverScreen();
    }

    private void Update()
    {
        Ui.ShowTime();
    }

    public void OnPlayAgainButtonClicked()
    {
        Ui.HideGameOverScreen();
        StartGame();
    }
}
