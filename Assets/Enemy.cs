using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage
{
    int hitpoints;
    int flash;
   public int test;
    Testing T;

    
    
    public virtual void Damage(int hitpoints, int flash)
    {
        Debug.Log("Damagee");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //this.Damage(hitpoints,flash);
       
       
    }
    public int testing()
    {
        return 3;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
