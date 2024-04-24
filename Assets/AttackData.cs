using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackData 
{
    // Start is called before the first frame update

    [SerializeField, HideInInspector] private string name;

    public void SetAttackName(int i) => name = $"Attack {i}";
}
