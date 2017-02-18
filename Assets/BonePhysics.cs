using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonePhysics : MonoBehaviour
{
    Rigidbody2D body;
    Vector3 lastPosition;
    float lastRotation;

    private Vector2 BonePosition
    {
        get
        {
            return this.transform.position;
        }
    }

    private float BoneRotation
    {
        get
        {
            return this.transform.rotation.eulerAngles.z;
        }
    }
    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        MoveBodyToBone();
    }

    private void Update()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        MoveBodyToBone();
    }

    void MoveBodyToBone()
    {
        this.body.MovePosition(BonePosition);
        this.body.MoveRotation(BoneRotation);
    }

    //void SetRotationToBone()
    //{
    //    this.transform.localRotation = bone.transform.localRotation;
    //}
}
