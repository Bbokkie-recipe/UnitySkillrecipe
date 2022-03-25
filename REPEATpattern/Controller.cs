using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private MovePattern movePattern;
    void Start()
    {
        movePattern.Setup(transform);
    }
    void Update()
    {
        movePattern.Apply(transform);
    }
}
