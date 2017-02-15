using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    Transform exhaust;

    public float speed;

    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
        var translation = Input.GetAxisRaw("Horizontal") * speed;

        this.transform.position += new Vector3(translation, 0, 0) * Time.deltaTime;
    }

    void FixedUpdate()
    {
        
    }
}
