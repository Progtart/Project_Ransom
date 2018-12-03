using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Vector3 change;
    SpriteRenderer rend;
    public Sprite up;
    public Sprite right;
    public Sprite down;
    public Sprite left;
    public float speed;
    Rigidbody2D body;
    Animator anim;
    public float X;
    // Use this for initialization
    void Start () {
        change = transform.position;
        rend = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        change[1] = Input.GetAxis("Vertical");
        change[0] = Input.GetAxis("Horizontal");
        body.velocity = change * speed;
        X = body.velocity[0] + body.velocity[1];
        anim.SetFloat("Speed", X);
        Debug.Log(X);
    }
}
