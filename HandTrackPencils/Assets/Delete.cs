using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public GameObject button;

    public void Press(int x){
        if (x == 1)
            Destroy(button); 
    }
}


