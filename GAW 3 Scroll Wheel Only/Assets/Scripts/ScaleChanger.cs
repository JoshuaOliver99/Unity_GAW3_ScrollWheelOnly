using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    public float maxScale;
    public float minScale;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public void OnGUI()
    {
        if (Event.current.isScrollWheel)
        {
            if (Event.current.delta.y < 0)
            {
                Debug.Log("GUI UP");
                float scale = Mathf.Min(maxScale, rb.gravityScale + 0.2f);
                rb.gravityScale = scale;
            }
            else if (Event.current.delta.y > 0)
            {
                Debug.Log("GUI DWON");
                float scale = Mathf.Max(minScale, rb.gravityScale - 0.2f);
                rb.gravityScale = scale;
            }
            /*
            if (Event.current.delta.y < 0)
            {
                Debug.Log("GUI UP");
                Vector3 currentScale = gameObject.transform.localScale;
                float scale = Mathf.Min(maxScale, currentScale.x * 1.1f);
                gameObject.transform.localScale = Vector3.one * scale;
            }
            else if (Event.current.delta.y > 0)
            {
                Debug.Log("GUI DWON");
                Vector3 currentScale = gameObject.transform.localScale;
                float scale = Mathf.Max(minScale, currentScale.x * 0.9f);
                gameObject.transform.localScale = Vector3.one * scale;
            }
            */

        }
    }
}
