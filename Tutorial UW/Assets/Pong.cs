using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigid2D;

	void Start () {
        rigid2D = GetComponent<Rigidbody2D>();
        rigid2D.velocity = new Vector2(speed, 0);
        }
	
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.name == "Square (1)")
        {
            rigid2D.velocity = new Vector2(-speed, rigid2D.velocity.y);
        } 
        if (coll.gameObject.name == "Square")
        {
            rigid2D.velocity = new Vector2(speed, rigid2D.velocity.y);
        }
    }
	// Update is called once per frame 
	void Update () {
		
	}
}
