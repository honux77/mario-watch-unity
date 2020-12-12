using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public float speed = 3.0f;
    bool seeRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        float dx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if (dx > 0 && !seeRight || dx < 0 && seeRight) {
            flip();
        }
        pos.x +=  dx;
        transform.position = pos;
    }

    void flip() {
        seeRight = !seeRight;
        Vector2 lc = transform.localScale;
        lc.x *= -1;
        transform.localScale = lc;        
    }
}
