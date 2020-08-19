﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RepeatingBackGround : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        groundHorizontalLength = groundCollider.size.x;
    }

    private void RepositionBackGround()
    {
        transform.Translate(Vector2.right * groundHorizontalLength * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundHorizontalLength)
        {
            RepositionBackGround();
        }
    }
}
