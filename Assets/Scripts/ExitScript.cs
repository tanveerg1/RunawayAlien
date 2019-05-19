using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour {
    public Button btnQuit; 

	// Use this for initialization
	void Start () {
        Button btn = btnQuit.GetComponent<Button>();
        btnQuit.onClick.AddListener(Exit);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Exit()
    {
        Application.Quit();
    }
}
