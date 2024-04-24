using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : GroundState
{
    public MoveState(Player player, PlayerStateMachine playerStateMachine, PlayerData playerData, string animationBoolName) : base(player, playerStateMachine, playerData, animationBoolName)
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

    // Start is called before the first frame update

}
