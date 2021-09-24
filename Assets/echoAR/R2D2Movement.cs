using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R2D2Movement : MonoBehaviour
{
    public float speed = 0.5f;
    private Vector3 posLeft;
    private Vector3 posRight;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<RemoteTransformations>().enabled = false;
        posLeft = transform.position;
        posRight = new Vector3(transform.position.x-40, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(posLeft, posRight, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
