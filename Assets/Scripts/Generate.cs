using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
    public GameObject asteroids;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacle", 1f, 4.5f);
	}

    void CreateObstacle()
    {
        Instantiate(asteroids);
    }
}
