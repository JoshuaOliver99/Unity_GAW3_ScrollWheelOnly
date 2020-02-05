using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
    // FOR COLOUR CHANGE
    //public SpriteRenderer spriteRenderer;
    public bool LevelEnded; // Used By level loader
    public string nextLevel; // Name of next level

    float maxScale = 5f;
    float minScale = 1f;
    float scaleSpeed = 4f;

    float rotateSpeed = -30f;

    float counter = 0f;

    void Update()
    {

        counter += Time.deltaTime;

        // ---------- ROTATE GOAL
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);

        // SCALE GOAL
        if (counter < 1) // Increase size
        {
            Vector3 currentScale = gameObject.transform.localScale;
            float scale = Mathf.Max(minScale, currentScale.x + scaleSpeed * Time.deltaTime);
            gameObject.transform.localScale = Vector3.one * scale;

        }
        else if (counter < 2) // Decrease size
        {
            Vector3 currentScale = gameObject.transform.localScale;
            float scale = Mathf.Min(maxScale, currentScale.x - scaleSpeed * Time.deltaTime);
            gameObject.transform.localScale = Vector3.one * scale;
        }
        else
            counter = 0;

        // ---------- colour changer method(){}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // ---------- DESTROY PLAYER
            Destroy(collision.gameObject);

            // ---------- play sound
            // ---------- play particles
            // ---------- shake screen
            // ---------- collaprse goal 
            // ---------- add delay

            // ---------- CHANGE LEVEL
            LevelEnded = true;

        }

    }
}
