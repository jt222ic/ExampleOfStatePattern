using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceDamage : MonoBehaviour,IDamage
{
    protected GameObject hej;
    public void Damage(int hitpoints, int flash)
    {
        Debug.Log("HADOUKEN");
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
