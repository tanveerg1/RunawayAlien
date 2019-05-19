using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {
    public Button btnStart;
	// Use this for initialization
	void Start () {
        Button btn = btnStart.GetComponent<Button>();
        btnStart.onClick.AddListener(TaskOnClick);
	}
	
    void TaskOnClick()
    {
        SceneManager.LoadScene("LevelOne");
    }
	// Update is called once per frame
	void Update () {
		
	}

}
