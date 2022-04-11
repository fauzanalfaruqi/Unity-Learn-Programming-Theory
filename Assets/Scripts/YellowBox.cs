using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance || INHERITANCE
public class YellowBox : Box
{
    [Space]
    [Header("Yellow Box Properties")]
    [SerializeField] Color[] colors;

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
        int rand = Random.Range(0, colors.Length);

        base.Jump();
        sprite.color = colors[rand];
    }
}
