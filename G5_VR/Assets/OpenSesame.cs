using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesame : MonoBehaviour
{
    public Animator door;


    void Start()
    {
 
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            door.Play("Door_Open");
        }
    }
}
