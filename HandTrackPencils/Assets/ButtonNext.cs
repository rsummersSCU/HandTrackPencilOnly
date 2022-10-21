using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonNext : MonoBehaviour
{
    public TextMeshProUGUI t1,t2,t3;
    public GameObject button;

    public void Press(int x){ 
      if(x == 1){    
           t1.enabled = false;
           t2.enabled = true;
           t3.enabled = true;

           MeshRenderer m = button.GetComponent<MeshRenderer>();
           m.enabled = true;

           CapsuleCollider c = button.GetComponent<CapsuleCollider>();
           c.enabled = true;

           Destroy(gameObject);
      }

      if(x == 2){
          t1.enabled = false;
          t2.enabled = true;
          Destroy(gameObject);
      }
    }
}
