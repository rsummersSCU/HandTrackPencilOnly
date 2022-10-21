using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PencilCounter : MonoBehaviour
{
     public TextMeshProUGUI counter, t1, t2,t3,t4;
     public GameObject button1, button2;
     public int pencils = 0;

    // Start is called before the first frame update
    void Start()
    {
       t4.text = string.Format("Nice Job! You have placed {0} pencils. Remember this number. Now, please take of your headset and go back to the Qualtrics survey.", pencils); 
    }

    void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == "Pencil"){
          pencils++;
          counter.text = string.Format("{0}", pencils);
          t4.text = string.Format("Nice Job! You have placed {0} pencils. Remember this number. Now, please take of your headset and go back to the Qualtrics survey.", pencils);
      }

      if(pencils >= 7){
        pencils = 7;
      }
}
}
