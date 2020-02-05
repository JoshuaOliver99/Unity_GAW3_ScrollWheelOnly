using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float RangeX, RangeY;
    public float moveSpeed;

    float startX, startY;
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
    }

    void Update()
    {
        move();
    }

    private void move()
    {
        //transform.Translate(Vector2.MoveTowards(transform.position.x, transform.position.x + MaxX, moveSpeed);
        if (transform.position.x < startX + RangeX)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        else if (transform.position.x > startX - RangeX) // gets into this loop then falls back into previous
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        

    }
}
