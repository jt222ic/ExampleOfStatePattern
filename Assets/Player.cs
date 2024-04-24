using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour ,IDamage
{
    // Start is called before the first frame update

    private PlayerStateMachine Statemachine { get;  set; }
    public Animator Anim;
    idleState idle;
    public MoveState move;
    PlayerData data;
    string animi;
    string test;
     int hitpoints, flash;
    #region myName

    int jan;
    #endregion
    private PlayerState playerbasestate
    { get; set; }
    public InputHandler inputHandler { get; set; }

    public Player instance { get; set; }
  
    private void Awake()
    {
        playerbasestate = new PlayerState(this, Statemachine, data, animi);
        Statemachine = new PlayerStateMachine();
          idle = new idleState(this,Statemachine,data,animi);
        move = new MoveState(this, Statemachine, data, animi);
      
    }

    // Update is called once per frame
    private void Start()
    {
        // innit
        Anim = GetComponent<Animator>();
        inputHandler = GetComponent<InputHandler>();

        
        Statemachine.Initialize(idle); // need to run something for the statemachien to 
     
    }

     void Update()
    {

        //var move = Input.GetAxis("Horizontal");

        //inputHandler.OnMoveInput(move);
           // Statemachine.currentstate.LogicUpdate();
        
       

    }

    private void FixedUpdate()
    {

        if (Statemachine.currentstate != null)
        {
            Statemachine.currentstate.PhysicialUpdate();
        }
    }

    public void Damage(int hitpoints, int flash)
    {
        
    }
}
