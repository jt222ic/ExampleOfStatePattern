using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="test" ,menuName ="Data/PlayerData")]
public class PlayerData : ScriptableObject
{
    // Start is called before the first frame update
    [SerializeField]
    public float speed = 5;
    public int hitpoints, flash;

  
}
