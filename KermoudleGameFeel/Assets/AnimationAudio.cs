using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TarodevController;
public class AnimationAudio : MonoBehaviour
{
    
    public PlayerController controller;

    public AudioSource source;

    public ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        controller.GroundedChanged += PlayAudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudioClip(bool hasJumped, float velocity)
    {
        if (hasJumped)
        {
            source.Play();
            particles.Play();
        }
    }
}
