using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject player;

    private CharacterController charController;

    private void Start()
    {
        charController = player.GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            charController.enabled = false;
            player.transform.position = new Vector3(13.0f, 4.0f, 15.5f);
            player.transform.rotation = Quaternion.identity;
            charController.enabled = true;
        }
    }
}
