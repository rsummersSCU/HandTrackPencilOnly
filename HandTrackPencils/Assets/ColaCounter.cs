using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColaCounter : MonoBehaviour

{
    public TextMeshProUGUI counter, t1, t2;
    public GameObject button;

    public int colas = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == "Can"){
           colas++;
           counter.text = string.Format("{0}", colas);
      }

      if(colas >= 7){
        t1.enabled = false;
        t2.enabled = true;

        MeshRenderer m1 = button.GetComponent<MeshRenderer>();
        m1.enabled = false;

        CapsuleCollider c1 = button.GetComponent<CapsuleCollider>();
        c1.enabled = false;
      }
    }
} 
