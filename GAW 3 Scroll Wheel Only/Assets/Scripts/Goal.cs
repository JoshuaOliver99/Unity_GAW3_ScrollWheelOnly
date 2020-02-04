using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // FOR COLOUR CHANGE
    //public SpriteRenderer spriteRenderer;

    public float maxScale = 4;
    public float minScale = 1;

    float counter = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        counter += Time.deltaTime;

        gameObject.transform.Rotate(Vector3.right);

        if (counter < 1)
        {
            Vector3 currentScale = gameObject.transform.localScale;
            float scale = Mathf.Max(minScale, currentScale.x * 0.9f);
            gameObject.transform.localScale = Vector3.one * scale;

        }
        else if (counter > 1 && counter < 2)
        {
            Vector3 currentScale = gameObject.transform.localScale;
            float scale = Mathf.Min(maxScale, currentScale.x * 1.1f);
            gameObject.transform.localScale = Vector3.one * scale;
        }
        else
            counter = 0;
    }
}
