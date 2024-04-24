using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    public int him;
    Core core;
    void Start()
    {
        core = GetComponent<Core>();
        
    }

    public virtual void Awareness()
    {
        Debug.Log("Raise Awareness");
    }

   
}
