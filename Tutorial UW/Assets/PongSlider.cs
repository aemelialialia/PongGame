using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongSlider : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigid2D;

    // Use this for initialization
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid2D.velocity = new Vector2(rigid2D.velocity.x, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid2D.velocity = new Vector2(rigid2D.velocity.x, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigid2D.velocity = new Vector2(rigid2D.velocity.x, -speed);
        }

    }
}
