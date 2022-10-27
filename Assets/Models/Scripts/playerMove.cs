using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float runSpeed = 1;
    public float rotationSpeed = 150;

    public Animator animatior;
    public Rigidbody rigidbody;

    public float jumpHeight = 1;
    public float groundDistance = 0.1f;
    public Transform groundCheck;
    public LayerMask groundMask;

    bool isGrounded;

    private float x, y;

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate    (0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate (0, 0, y * Time.deltaTime * runSpeed);

        animatior.SetFloat("VelX", x);
        animatior.SetFloat("VelY", y);

        if (Input.GetKey("c"))
        {
            animatior.SetBool("Other", false);
            animatior.Play("Fail");

        }

        if (x>0 || x<0 || y>0 || y < 0)
        {
            animatior.SetBool("Other", true);
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (Input.GetKey("space") && isGrounded)
        {
            animatior.Play("Jump");
            Invoke("Jump", 1/4);
        }
    }

    public void Jump()
    {
        rigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
    }   
}
