using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{


    weapon weapon;
    private bool exen;
    // Start is called before the first frame update
    void Start()
    {
        weapon = GetComponentInChildren<weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        weapon.Slash();
    }



   public void testing()
    {

    }
}
