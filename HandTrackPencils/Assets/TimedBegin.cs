using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimedBegin : MonoBehaviour
{
    public TextMeshProUGUI t;
     // Start is called before the first frame update
    void Start()
    {
        t.enabled = false;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        t.enabled = true;
    }
}
