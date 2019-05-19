using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {
    public GameObject astbelt;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 20f);
    }

    void CreateObstacle()
    {
        Instantiate(astbelt);
    }
}
