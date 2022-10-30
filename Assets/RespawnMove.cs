using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnMove : MonoBehaviour
{
    public Transform origin;
    public Rigidbody rigidBody;
    public float velocity = 0.5f;
    public LayerMask layerPlayer;

    public Animator animatior;
    public bool isAlert;

    // Update is called once per frame
    void Update()
    {
        isAlert = Physics.CheckSphere(transform.position, 1, layerPlayer);
        transform.position = Vector3.MoveTowards(transform.position, origin.position, velocity);
    }

    public void Jump()
    {
        animatior.Play("Floating");
        rigidBody.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
