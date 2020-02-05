using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    public bool canChangeScale = false;


    float timer;
    float maxScale = 3;
    float minScale = 0.5f;


    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;
    }

    public void OnGUI()
    {
        if (Event.current.isScrollWheel && canChangeScale)
        {
            // CHANGE SCALE 
            if (Event.current.delta.y < 0)
            {
                Vector3 currentScale = gameObject.transform.localScale;
                float scale = Mathf.Min(maxScale, currentScale.x * 1.1f);
                gameObject.transform.localScale = Vector3.one * scale;
            }
            else if (Event.current.delta.y > 0)
            {
                Vector3 currentScale = gameObject.transform.localScale;
                float scale = Mathf.Max(minScale, currentScale.x * 0.9f);
                gameObject.transform.localScale = Vector3.one * scale;
            }

            timer = 0f;
        }
    }
}
