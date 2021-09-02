using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    public GameObject tunnel;
    public float Speed = 1.0f;
    public float stopTime = 2f;
    private bool goingUp = true;
    private Vector3 distanceToMove;
    private float tunnelStartingY;
    private bool stopped;
    private float stoppedTime;
    

    // Start is called before the first frame update
    void Start()
    {
        tunnel = gameObject;
        distanceToMove = new Vector3(0, Speed, 0);
        tunnelStartingY = transform.position.y;
}

    // Update is called once per frame
    void Update()
    {
        // Switch going up if tunnel moves out of bounds
        if (transform.position.y <= tunnelStartingY || transform.position.y >= tunnelStartingY + 10)
        {
            if (!stopped)
            {
                stoppedTime = Time.time;
                stopped = true;
            }
            if (Time.time > stoppedTime + stopTime)
            {
                goingUp = !goingUp;
                stopped = false;
                    
            }
        }

        // Move tunnel up if going up and down if going down
        if (transform.position.y < tunnelStartingY + 10 && goingUp)
        {
            transform.position += distanceToMove * Time.deltaTime;
        }
        else if (transform.position.y > tunnelStartingY && !goingUp)
        {
            transform.position += -distanceToMove * Time.deltaTime;
        }

    }
}
