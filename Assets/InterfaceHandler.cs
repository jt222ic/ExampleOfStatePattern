using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class InterfaceHandler : MonoBehaviour
{
    // Start is called before the first frame update

    List<IDamage> listOfI = new List<IDamage>();

    public InterfaceDamage BaseClass;
    int hit, flash;
    void Start()
    {

        //listofi.add(BaseClass.GetComponent<IDamage>());
        listOfI.Add(BaseClass.GetComponent<IDamage>());
        Debug.Log(listOfI.Count);

        foreach(IDamage damagable in listOfI.ToList())
        {
    
         if (damagable != null)
            {
                
                damagable.Damage(hit,flash);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
