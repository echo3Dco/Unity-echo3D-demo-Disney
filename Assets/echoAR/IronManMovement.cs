using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronManMovement : MonoBehaviour
{
    public float speed = 5.5f;
    private int isUp = 1;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<RemoteTransformations>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 40)
        {
            isUp = -1;
            timer += Time.deltaTime;
            float seconds = timer % 60;
            if (seconds >= 2f)
            {
                timer = 0.0f;
                transform.Translate(isUp * Vector2.up * speed * Time.deltaTime);
            }
        }
        else if (transform.position.y <= 0)
        {
            isUp = 1;
            timer += Time.deltaTime;
            float seconds = timer % 60;
            if (seconds >= 2f)
            {
                timer = 0.0f;
                transform.Translate(isUp * Vector2.up * speed * Time.deltaTime);
            }
        }
        else
            transform.Translate(isUp * Vector2.up * speed * Time.deltaTime);
        
    }
}
