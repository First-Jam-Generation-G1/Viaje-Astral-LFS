using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnMove : MonoBehaviour
{
    public Transform origin;
    public Rigidbody rigidBody;
    public float velocity = 0.1f;
    public LayerMask layerPlayer;

    public Animator animatior;
    public bool isAlert;

    public Vector3 respawnPosition;

    // Update is called once per frame
    void Update()
    {
        isAlert = Physics.CheckSphere(transform.position, 1, layerPlayer);
        transform.position = Vector3.MoveTowards(transform.position, respawnPosition, velocity);
    }

    public void Jump()
    {
        animatior.Play("Floating");
        rigidBody.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
