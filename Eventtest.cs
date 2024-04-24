using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestingEvents : MonoBehaviour
{
   // Handle the fire up Event and invocation
   // logic business should not be assosiactet with view.
   // EventsArgs is passing more information through events
    public event EventHandler<EventPressArgs> OnButtonClick;
  
    public class EventPressArgs : EventArgs
    {
        public int spaceCount;
    }

    private int spaceCount;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Space 

            // null check if eventhandler has any subscriber
            OnButtonClick?.Invoke(this, new EventPressArgs { spaceCount = spaceCount }); 
        }
    }
}
