using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats 
{

    
    public Vector2 Direction { get; set; }

    public float Speed { get; set; }

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float walkSpeed;

    [SerializeField]
    private float runSpeed;


    [SerializeField]
    private int lives;

    [SerializeField]
    private float immortalityTime;



   /* [SerializeField]
    private float KBForce;

    [SerializeField]
    private float KBConter;

    [SerializeField]
    private float KBTotalTime;

    private bool knockFromRight;*/

    //private WEAPON weapon;

    public float WalkSpeed 
    { get => walkSpeed;}
    public float JumpForce { get => jumpForce; }

    public bool Alive
    {
        get
        {
            return Lives > 0;
        }
    }
    //public WEAPON Weapon { get => weapon; set => weapon = value; }

    //public Dictionary<WEAPON, bool> Weapons { get; set; } = new Dictionary<WEAPON, bool>();
    public int Lives { get => lives; set => lives = value; }

    public bool IsImmortal { get; set; }
    public float ImmortalityTime { get => immortalityTime; set => immortalityTime = value; }
    public float RunSpeed { get => runSpeed; }
   /* public float KBForce1 { get => KBForce; set => KBForce = value; }
    public float KBConter1 { get => KBConter; set => KBConter = value; }
    public float KBTotalTime1 { get => KBTotalTime; set => KBTotalTime = value; }
    public bool KnockFromRight { get => knockFromRight; set => knockFromRight = value; }*/
}
   