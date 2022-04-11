using System;
using System.Collections;
using UnityEngine;

// Inheritance || INHERITANCE
public class GreenBox : Box
{
    [Space]
    [Header("Green Box Properties")]
    [SerializeField] Vector3 rotationValue;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        
        // Abstraction || ABSTRACTION
        KeepBoxInside();
    }

    // Polymorphism || POLYMORPHISM
    public override void Jump()
    {
        base.Jump();
        transform.rotation *= Quaternion.Euler(rotationValue);
    }
}
