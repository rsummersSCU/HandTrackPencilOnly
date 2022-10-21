using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimedErase : MonoBehaviour
{
    public TextMeshProUGUI t;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        t.enabled = false;
    }

}
