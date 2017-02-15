using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneToPhysics : MonoBehaviour
{
    Rigidbody2D body;
    Transform lastTransform;

    // Use this for initialization
    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        this.lastTransform = this.transform;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        var translation = this.transform.position - lastTransform.position;
        var rotation = this.transform.rotation.eulerAngles.z;
        this.body.MovePosition(this.transform.position + translation);
        this.body.MoveRotation(rotation);

        
        this.lastTransform = this.transform;
	}
}
