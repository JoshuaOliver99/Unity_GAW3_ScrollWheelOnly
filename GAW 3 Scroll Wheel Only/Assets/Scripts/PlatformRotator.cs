using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotator : MonoBehaviour
{
    public float rotateSpeed = -60f; // Negative = clockwise
    Rigidbody2D rb;

    void Update()
    {
        // ---------- ROTATE
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}
