using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovePattern : MonoBehaviour
{
    [SerializeField]
    public float speed;
    public float Speed => speed;
    public Vector2 Center { get; private set; }
    public virtual void Setup(Transform target)
    {
        Center = target.position;
    }

    public abstract void Apply(Transform target);
}
