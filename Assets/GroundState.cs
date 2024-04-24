using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundState : PlayerState
{

    protected Vector2 input;

    public GroundState(Player player, PlayerStateMachine playerStateMachine, PlayerData playerData, string animationBoolName) : base(player, playerStateMachine, playerData, animationBoolName)
    {
        
    }

    public override void Enter()
    {
        base.Enter();
      
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        input = player.inputHandler.MoveInput;
    }

    public override void OnCheck()
    {
        base.OnCheck();
    }

    public override void OnCollisionCheck()
    {
        base.OnCollisionCheck();
    }

    public override void PhysicialUpdate()
    {
        base.PhysicialUpdate();
    }

    

}
