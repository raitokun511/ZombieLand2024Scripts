using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Button3D : MonoBehaviour
{
    public UnityEvent myEvent;

    private void OnMouseUpAsButton()
    {
        if (myEvent.GetPersistentEventCount() != 0)
        {
            Debug.Log("Event: " + myEvent);
            myEvent.Invoke();
        }
        else
            Debug.Log("No CLick Event");
    }
}
