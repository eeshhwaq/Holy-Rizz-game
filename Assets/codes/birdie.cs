using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdie : MonoBehaviour
{
    public Rigidbody2D myrigidbody2D;
    public float flapstrnegth;
    public logicman logic;
    public bool alive = true;
    public AudioClip jumpclip;
    public AudioSource audio;
    public bool gocheck = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "rizzy";
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicman>();

    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKeyDown(KeyCode.Space) && alive == true)
        {
            audio.clip = jumpclip;
            audio.Play();

        myrigidbody2D.velocity = Vector2.up * flapstrnegth;
    }
        if (transform.position.y  > 20 || transform.position.y < -20)
        {
            logic.gameover();
                alive = false;
        }    
}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        gocheck = true;
        alive = false;
    }
}
