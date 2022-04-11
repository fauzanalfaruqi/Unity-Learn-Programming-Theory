using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public SpriteRenderer sprite;
    [HideInInspector] public BoxCollider2D boxCollider;
    [HideInInspector] public float jumpForce;

    [Header("Box Base Properties")]
    public Color cubeColor;
    public Vector3 cubeScale;
    public float cubeMass;

    void Awake()
    {
        // Get all the references
        rb = gameObject.GetComponent<Rigidbody2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
        jumpForce = 500.0f;

        // Set the properties values
        sprite.color = cubeColor;
        transform.localScale = cubeScale;
        rb.mass = cubeMass;
    }

    public virtual void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }

    public void KeepBoxInside()
    {
        if (transform.position.y > 4.5f)
        {
            rb.AddForce(Vector2.down * 250.0f);
        }
    }
}
