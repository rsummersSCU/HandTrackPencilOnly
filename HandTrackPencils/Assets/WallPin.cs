using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "wall")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
