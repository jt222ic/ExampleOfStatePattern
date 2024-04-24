using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleState : GroundState
{

    Player player;
    Player p_player;
    public idleState(Player player, PlayerStateMachine playerStateMachine, PlayerData playerData, string animationBoolName) : base(player, playerStateMachine, playerData, animationBoolName)
    {

        player = base.player;
        p_player = player;
    }

    // Start is called before the first frame update
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

        if(input.x >0f)
        {
            playerstatemachine.ChangingState(player.move);  // you getting class player from Playerstate, can be a bit confusing if you are not aware
        }
        player.Damage(playerData.hitpoints,playerData.flash);
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

    public override string ToString()
    {
        return base.ToString();
    }
}
