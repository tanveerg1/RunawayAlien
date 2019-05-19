using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBelt : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "astobelt")
        {
            Destroy(collision.gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
