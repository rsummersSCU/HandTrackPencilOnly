using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextStep : MonoBehaviour
{
    public TextMeshProUGUI t1,t2,t3,t4;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider col){
      if(col.gameObject.name == "Scissors_blue"){
           t1.enabled = false;
           t2.enabled = true;
           t3.enabled = true;
           t4.enabled = true;

           MeshRenderer m = button.GetComponent<MeshRenderer>();
           m.enabled = true;

           CapsuleCollider c = button.GetComponent<CapsuleCollider>();
           c.enabled = true;
      }
 }
}
