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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAnimation(bool hasJumped, float velocity)
    {
        if (hasJumped)
        {
            //Animator.
        }
    }
}
