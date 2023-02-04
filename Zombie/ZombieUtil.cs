using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieUtil 
{
    private Zombie zombie;


    private List<Command> commands = new List<Command>();
    public ZombieUtil(Zombie zombie)
    {
        this.zombie = zombie;
       
        //commands.Add(new ZAttackCommand(zombie, KeyCode.LeftControl));
       



    }

    public void HandleInput()
    {
        zombie.Stats.Direction = new Vector2(Input.GetAxisRaw("Horizontal"), zombie.Components.Rb.velocity.y);

        foreach (Command command in commands)
        {
            if (Input.GetKeyDown(command.Key))
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
        RaycastHit2D hit = Physics2D.BoxCast(zombie.Components.Collider.bounds.center, zombie.Components.Collider.bounds.size, 0, Vector2.down, 0.1f, zombie.Components.GroundLayer);

        return hit.collider != null;
    }

    
    
}
