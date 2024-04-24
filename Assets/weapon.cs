using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : CoreComponent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //core.testing();
       

    }
    public void Slash()
    {
        Debug.Log("SLASH");
    }

    protected override void Awake()
    {
        

        base.Awake();
        //core.BIgTest = false;

        //print(core.BIgTest);
        //core = transform.parent.GetComponent<Core>();

        //if (core == null) { Debug.LogError("There is no Core on the parent / WEAPON"); }
    }
}
