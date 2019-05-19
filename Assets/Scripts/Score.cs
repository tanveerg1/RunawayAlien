using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    private static int score;
    public Text textScore;
    public Text highScore;
    public GameObject player;
    public PlayerController playerC;

	// Use this for initialization
	void Start () {
        //score = 0;
        //InvokeRepeating("ScoreUpdate", 2.5f, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
        ScoreUpdate();
        //textScore.text = "Score : " + score;
        textScore.text = playerC.score.ToString();
        highScore.text = "HighScore : " + PlayerPrefs.GetInt("best");
	}
    
    //ScoreUpdate
    void ScoreUpdate()
    {
        if (player)
        {
            //score += 1;
            int high = PlayerPrefs.GetInt("best", 0);
            if(playerC.score > high)
            {
                PlayerPrefs.SetInt("best", playerC.score);
            }
        }
    }
}
