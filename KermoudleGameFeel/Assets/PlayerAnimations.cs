using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    public Animator animations;

    public PlayerController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller.GroundedChanged += ChangeAnimation;
        controller.movementChanged += ChangeAnimation;
    }



    public void ChangeAnimation(bool hasJumped, float velocity)
    {
        animations.SetBool("Grounded",hasJumped);
    }

    public void ChangeAnimation(float speed)
    {
        animations.SetFloat("Speed", speed);
    }
}
