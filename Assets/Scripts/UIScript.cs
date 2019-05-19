using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    public Button[] buttons;
    bool gameOver;

	// Use this for initialization
	void Start () {
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Exit the application
    public void Exit()
    {
        Application.Quit();
    }

    //Reload
    public void Replay()
    {
        SceneManager.LoadScene("LevelOne");
    }

    //Load Menu
    public void Menu()
    {
        SceneManager.LoadScene("mainmenu");
    }

    //gameover window
    public void gameOverActivated()
    {
        gameOver = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
}
