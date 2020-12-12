using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpForce = 700.0f;
    private bool seeRight = true;
    private bool isJumping = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetButtonDown("Jump")) jump();

        float dx = Input.GetAxis("Horizontal") * speed;
        
        if (dx > 0 && !seeRight || dx < 0 && seeRight) {
            flip();
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(dx,GetComponent<Rigidbody2D>().velocity.y);
    }

    void jump() {
        Debug.Log("Jump");
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
    }

    void flip() {
        seeRight = !seeRight;
        Vector2 lc = transform.localScale;
        lc.x *= -1;
        transform.localScale = lc;        
    }
}
