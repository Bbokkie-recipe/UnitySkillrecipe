using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePattern : MovePattern
{
    [SerializeField]
    private float radius;
    public override void Apply(Transform target)
    {
        var offset = Time.time * Speed;
        target.position = new Vector2(Mathf.Sin(offset), Mathf.Cos(offset)) * radius;
    }
}
