using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Explosion not working will never fix it
public class ExplosionAnimation : MonoBehaviour {

    //Explosion
    public void Explosion()
    {
        GetComponent<Animation>().Play("NewExplosion");
        //GetComponent<Animation>().CrossFade("NewExplode", 0.5f, PlayMode.StopAll);
        print("EXPLODE");
    }
}
