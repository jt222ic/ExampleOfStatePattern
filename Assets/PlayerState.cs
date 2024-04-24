using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public  class PlayerState 
{
    protected Player player;                   // difference between protect and private, is that protected can be accessable if the classes inherits(derrive)
    protected PlayerStateMachine playerstatemachine;
    protected PlayerData playerData;
    protected float startTime;
    protected string animationBoolName;

    public PlayerState(Player player,PlayerStateMachine playerStateMachine, PlayerData playerData, string animationBoolName)
    {
        this.player = player;
        this.playerstatemachine = playerStateMachine;
        this.animationBoolName = animationBoolName;
        this.playerData = playerData;
    }

    public PlayerState(Player player)
    {
        this.player = player;
    }

    public virtual void Enter()
    {
        OnCheck();
        startTime = Time.deltaTime;

        if (animationBoolName != null)
        {
            this.player.Anim.SetBool(animationBoolName, true);
        }
      

    }
    public virtual void Exit()
    {
        this.player.Anim.SetBool(animationBoolName, false);
    }
    public virtual void LogicUpdate()
    {
        

    }
    public void test()
    {

    }
    public virtual void PhysicialUpdate()  // fixed update
    {

    }
    public virtual void OnCheck()
    {

    }
    public virtual void OnCollisionCheck()
    {

    }

  
}
