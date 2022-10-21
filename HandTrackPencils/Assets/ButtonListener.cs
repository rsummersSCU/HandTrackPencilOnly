using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.Events;

public class ButtonListener : MonoBehaviour
{

    public UnityEvent proximityEvent;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ButtonController>().InteractableStateChanged.AddListener(InitiateEvent);
    }

    void InitiateEvent(InteractableStateArgs state){

        if(state.NewInteractableState == InteractableState.ProximityState)
            proximityEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
