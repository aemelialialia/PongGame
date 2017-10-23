using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigid2D;

	// Use this for initialization
	void Start () {
        rigid2D = GetComponent<Rigidbody2D>();		
	}
	
	// Update is called once per frame
	void Update () {
        rigid2D.velocity = new Vector2(0, rigid2D.velocity.y);
        if (Input.GetKey(KeyCode.RightArrow)) {
            rigid2D.velocity = new Vector2(speed, rigid2D.velocity.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigid2D.velocity = new Vector2(-speed, rigid2D.velocity.y);
        }
		
	}
}
