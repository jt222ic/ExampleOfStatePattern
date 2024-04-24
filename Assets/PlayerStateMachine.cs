using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine 
{

   public  PlayerState currentstate;

    public void Initialize(PlayerState startingstate)
    {
        
        currentstate = startingstate;
        currentstate.Enter();
        
    }
    public void ChangingState(PlayerState newstate)
    {

        currentstate.Exit();               // exit the old state
        currentstate = newstate;
        currentstate.Enter();
    }



   

  

  



  


   
}
