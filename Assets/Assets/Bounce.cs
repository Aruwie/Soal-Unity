using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public int currentCount = 0;

    void Go()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(100, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-200, 15));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("Go", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d.velocity.x == 0)
        {
            rb2d.velocity = new Vector2(Random.Range(1, 3), rb2d.velocity.y);
        }
        else if (rb2d.velocity.y == 0)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, Random.Range(1, 3));
        }
    }
}
