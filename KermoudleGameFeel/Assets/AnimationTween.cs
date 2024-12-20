using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening; 
using UnityEngine;

public class AnimationTween : MonoBehaviour
{

    public Vector3 targetSize;
    public float duration;
    public float elasticity;
    public int vibratio;
    private void OnEnable()
    {
        Animate();
        Debug.Log("hit" , this);
    }

    public void Animate()
    {
        transform.DOPunchScale(targetSize,duration,vibratio,elasticity);
    }
}
