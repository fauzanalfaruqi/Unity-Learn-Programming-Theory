using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance || INHERITANCE
public class RedBox : Box
{
    [Header("Red Box Properties")]
    [SerializeField] Vector3[] scale;

    void Update()
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
        int rand = Random.Range(0, scale.Length);

        base.Jump();
        rb.transform.localScale = scale[rand];
    }
}
