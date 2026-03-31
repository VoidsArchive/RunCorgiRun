using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnStartButtonClicked()
    {
        Ui.HideStartScreen();
    }
}
