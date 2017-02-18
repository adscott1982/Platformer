using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    public GameObject Ragdoll;
    Animator animator;
    Transform exhaust;

    public float speed;

    // Use this for initialization
    void Start()
    {

        this.animator = this.Ragdoll.GetComponent<Animator>();
    }

    void Update()
    {
        var translation = Input.GetAxisRaw("Horizontal") * speed;
        var kick = Input.GetButtonDown("Fire1");
        var isKicking = animator.GetCurrentAnimatorStateInfo(0).IsName("Kick");

        if (!isKicking || animator.IsInTransition(0)) animator.SetBool("Kick", kick);
        else animator.SetBool("Kick", false);

        this.transform.position += new Vector3(translation, 0, 0) * Time.deltaTime;
    }

    void FixedUpdate()
    {
        
    }
}
