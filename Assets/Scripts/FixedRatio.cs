using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedRatio : MonoBehaviour {
    public float orthographicSize = 5;
    public float aspect = 1.33333f;

	// Use this for initialization
	void Start () {
        Screen.SetResolution((int)Screen.width, (int)Screen.height, true);
        //Camera.main.projectionMatrix = Matrix4x4.Ortho(-orthographicSize * aspect, orthographicSize * aspect,
          //  -orthographicSize, orthographicSize, Camera.main.nearClipPlane, Camera.main.farClipPlane);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
