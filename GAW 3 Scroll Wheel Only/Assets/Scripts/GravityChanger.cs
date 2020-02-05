using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    public bool canChangeGravity = false;

    float timer;
    float timerDelay = 2f;

    float maxGravity = 2;
    float minGravity = -2;

    Rigidbody2D rb;

    void Start()
    {
        timer = timerDelay;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Debug.Log(rb.gravityScale);
        timer += Time.deltaTime;

        if (timer > timerDelay)
        { 
            // ALL DOES NOTHING
            transform.GetChild(0).Rotate(0, 0, 5f * Time.deltaTime);
            gameObject.GetComponentInChildren<Renderer>().material.color = Color.magenta;
        }
        else if (rb.gravityScale > 0)
            GetComponent<Renderer>().material.color = Color.red;
        else if (rb.gravityScale < 0)
            GetComponent<Renderer>().material.color = Color.blue;
    }

    public void OnGUI()
    {
        if (Event.current.isScrollWheel && timer > timerDelay && canChangeGravity)
        {
            if (Event.current.delta.y < 0) // Scroll up, Increase gravity, Add up velocity 
            {
                rb.gravityScale = minGravity; // Set gravity to negative gravity
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + 3 * Time.deltaTime); // Add some up velocity
            }
            else if (Event.current.delta.y > 0) // Scroll up, Increase gravity, Add down velovity
            {
                rb.gravityScale = maxGravity; // Set gravity to posotive gravity
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - 3 * Time.deltaTime); // Add some up velocity
            }

            timer = 0f;

        }
    }
}
