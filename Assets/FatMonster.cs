using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatMonster : Monster
{

    Core core;

    public FatMonster()
    {
    }

    public override void Awareness()
    {
        base.Awareness();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }

    // Start is called before the first frame update


    void Start()
    {
        core = GetComponent<Core>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
