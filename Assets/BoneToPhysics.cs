﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneToPhysics : MonoBehaviour
{
    public GameObject bone;
    Rigidbody2D body;
    Vector3 lastPosition;
    float lastRotation;

    private Vector2 BonePosition
    {
        get
        {
            return this.bone.transform.position;
        }
    }

    private float BoneRotation
    {
        get
        {
            return this.bone.transform.rotation.eulerAngles.z;
        }
    }
    // Use this for initialization
    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        SetRotationToBone();
        MoveBodyToBone();
    }

    private void Update()
    {
        SetRotationToBone();
    }

	// Update is called once per frame
	void FixedUpdate ()
    {
        
        MoveBodyToBone();
    }

    void MoveBodyToBone()
    {
        this.body.MovePosition(BonePosition);
        this.body.MoveRotation(BoneRotation);
    }

    void SetRotationToBone()
    {
        this.transform.localRotation = bone.transform.localRotation;
    }
}
