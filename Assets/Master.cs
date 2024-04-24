using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    // Start is called before the first frame update
    OOPTraining OOP;
    bool test;
    void Start()
    {
        OOP = new OOPTraining();
        OOP.Size = 10;
        print(OOP.Size);
        OOP.Accounting = 0;
        print(OOP.Accounting);
        OOP.Confirm = false;
        if (OOP.Confirm)
        {
            Debug.Log("Property function");
            
        }
        if(OOP.OnCheck())
        {
            Debug.Log("Normal function");
            test = OOP.OnCheck();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class OOPTraining
{
    private int size;
    private string name;
    private int accounting;
    private bool confirm;

    #region Properties

    public int Size
    {
        get { return size/2; }
        set { size = value; }
    }
    public int Accounting
    {
        get { return accounting; }
        set { if (value < 0)
            {

            }
            else
            { accounting = value; }
        }
    }

    public bool Confirm
    {
        get { return confirm; }
        set { confirm = value; }
            
    
    }
    public bool ONTEST()
    {
        return false;
    }
    public bool OnCheck()
    {
        return true;
    }
    #endregion



}
