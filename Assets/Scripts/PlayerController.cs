using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // The force which is added when the player jumps
    // This can be changed in the Inspector window
    public Vector2 jumpForce = new Vector2(0, 300);
    public Rigidbody2D rigid;
    public float spd = 5f;
    public UIScript ui;
    public int score;
    public GameObject explosion;
    public ExplosionAnimation _explosionAnimation;
    //public AnimationClip anim;

    //start
    void Start()
    {
        //anim = GetComponent<AnimationClip>();
        rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            rigid.velocity = new Vector2(0, spd);
        }
        // Jump
        if (Input.GetKeyUp("space"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }

        //Die off Screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0) {
            Destroy(gameObject);
            ui.gameOverActivated();
        }
    }

    //Die by collision
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        //Animation not working will never fix it
        if (collision.gameObject.tag == "obstac")
        {
            
            //GetComponent<Animation>().clip = anim;
            //GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //transform.position = new Vector3(transform.position.x - spd, transform.position.y, transform.position.z);
            //GetComponent<Animation>().Play("NewExplosion");
            //print(anim["NewExplode"].length);
            //anim.CrossFade("NewExplode", 1/2);
            //transform.localScale = new Vector3(-.75f, transform.localScale.y, transform.localScale.z);
            //_explosionAnimation.Explosion();
            Destroy(gameObject);
            
            //explosion.GetComponent<Animation>().Play();
            
            ui.gameOverActivated();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ScoreZone")
        {
            score++;
        }
    }
}
