using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUpDown : MonoBehaviour
{
    public float Speed = 0.5f;
    public float stopTime = 2f;
    public float totalChange = 10f;

    private Vector3 amountToScale;
    private bool goingUp = true;
    private float startingScale;
    private bool stopped = false;


    // Start is called before the first frame update
    void Start()
    {
        amountToScale = new Vector3(1 * Speed, 0, 0);
        startingScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Switch goingUp if tunnel is below its starting position or above the height offset, is not stopped, and is going in the wrong direction
        if ((transform.localScale.x <= startingScale && !goingUp && !stopped) || (transform.localScale.x >= startingScale + totalChange && goingUp && !stopped))
        {

            StartCoroutine(StopTimer());
        }

        // Move tunnel in the direction of goingUp
        if (!stopped && goingUp)
        {
            transform.localScale += amountToScale * Time.deltaTime;
        }
        else if (!stopped && !goingUp)
        {
            transform.localScale += -amountToScale * Time.deltaTime;
        }

    }

    IEnumerator StopTimer()
    {
        stopped = true;
        yield return new WaitForSeconds(stopTime);
        goingUp = !goingUp;
        stopped = false;
    }
}
