using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public bool rotateX;
    public bool rotateY;
    public bool rotateZ;

    public float speed = 1.0f;

    private Vector3 toRotate;

    // Start is called before the first frame update
    void Start()
    {
        toRotate = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate in every direction that the rotate varialble is true
        gameObject.transform.Rotate(rotateX ? speed * Time.deltaTime : 0, rotateY ? speed * Time.deltaTime : 0, rotateZ ? speed * Time.deltaTime : 0);
    }
}
