using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject Door;
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // COLLISION WITH PLAYER
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroys other
            Destroy(Door);
        }


    }
}
