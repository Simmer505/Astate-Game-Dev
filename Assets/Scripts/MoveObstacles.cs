using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacles : MonoBehaviour
{
    public float speed = 1;
    public bool stopAtX;
    public bool stopAtY;
    public bool stopAtZ;
    public bool toPositive;

    public float stopCoord;


    // Update is called once per frame
    void Update()
    {
        if ((stopAtX && gameObject.transform.position.x < stopCoord && toPositive) || (stopAtX && gameObject.transform.position.x > stopCoord && !toPositive))
        {
            gameObject.transform.Translate(new Vector3((toPositive ? speed : -speed) * Time.deltaTime, 0, 0), Space.World);
        } 
        else if ((stopAtY && gameObject.transform.position.y < stopCoord && toPositive) || (stopAtY && gameObject.transform.position.y > stopCoord && !toPositive))
        {
            gameObject.transform.Translate(new Vector3(0, (toPositive ? speed : -speed) * Time.deltaTime, 0), Space.World);
        }
        else if ((stopAtZ && gameObject.transform.position.z < stopCoord && toPositive) || (stopAtZ && gameObject.transform.position.z > stopCoord && !toPositive))
        {
            gameObject.transform.Translate(new Vector3(0, 0, (toPositive ? speed : -speed) * Time.deltaTime), Space.World);
        } 
        else
        {
            Destroy(gameObject);
        }
    }
}
