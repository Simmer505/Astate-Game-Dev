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
    private bool stopped = false;
    

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
        // Switch goingUp if tunnel moves out of bounds after a delay set by stopTime
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.y <= tunnelStartingY && !goingUp && !stopped || transform.position.y >= tunnelStartingY + 10 && goingUp && !stopped);
        if ((transform.position.y <= tunnelStartingY && !goingUp && !stopped) || (transform.position.y >= tunnelStartingY + 10 && goingUp && !stopped))
        {
            
            StartCoroutine(StopTimer());
        }

        // Move tunnel in the direction of goingUp
        if (!stopped && goingUp)
        {
            transform.Translate(distanceToMove * Time.deltaTime, Space.World);
        }
        else if (!stopped && !goingUp)
        {
            transform.Translate(-distanceToMove * Time.deltaTime, Space.World);
        }

    }

    IEnumerator StopTimer ()
    {
        stopped = true;
        yield return new WaitForSeconds(stopTime);
        goingUp = !goingUp;
        stopped = false;
    }
}
