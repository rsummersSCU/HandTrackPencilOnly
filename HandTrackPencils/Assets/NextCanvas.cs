using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextCanvas : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject Canvas1, Canvas2;
    
    public void Press(int x){
        if(x == 1){
            Destroy(Canvas1);
            Canvas c = Canvas2.GetComponent<Canvas>();
            c.enabled = true;
        }
    }
}
