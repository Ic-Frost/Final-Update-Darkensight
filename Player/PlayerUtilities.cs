using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUtilities 
{
    private Player player;


    private List<Command> commands = new List<Command>();
    public PlayerUtilities(Player player)
    {
        this.player = player;
        commands.Add(new JumpCommand( player ,KeyCode.Space));
        commands.Add(new AttackCommand(player, KeyCode.LeftControl));
        //commands.Add(new WeaponSwapCommand(player, WEAPON.FISTS, KeyCode.Alpha1));
        //commands.Add(new WeaponSwapCommand(player, WEAPON.Sword, KeyCode.Alpha2));
        



    }

    public void HandleInput()
    {
        player.Stats.Direction = new Vector2(Input.GetAxisRaw("Horizontal"),player.Components.Rb.velocity.y);

        foreach(Command command in commands)
        {
            if(Input.GetKeyDown(command.Key))
            {
                command.GetKeyDown();
            }

            if (Input.GetKeyUp(command.Key))
            {
                command.GetKeyUp();
            }

            if (Input.GetKey(command.Key))
            {
                command.GetKey();
            }
        }

       


    }

    public bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast(player.Components.Collider.bounds.center, player.Components.Collider.bounds.size, 0, Vector2.down, 0.1f, player.Components.GroundLayer);

        return hit.collider != null;
    }

    public void HandleAir()
    {
        if(IsFalling())
        {
            player.Components.Animator.TryPlayAnimation("Fall");
        }

    }
    private bool IsFalling()
    {
        if( player.Components.Rb.velocity.y < 0!) //&& isGrounded())
        {
            return true;
        }
        return false;
    }
   
}
