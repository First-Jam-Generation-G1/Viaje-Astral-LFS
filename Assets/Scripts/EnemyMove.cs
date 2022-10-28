using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float sphereRadiusVision;
    public LayerMask layerPlayer;
    public Transform player;
    public bool isAlert;
    public float velocity = 0.05f;

    public Animator animatior;

    // Update is called once per frame
    void Update()
    {
        animatior.Play("Floating");
        isAlert = Physics.CheckSphere(transform.position, sphereRadiusVision, layerPlayer);

        if (isAlert)
        {
            transform.LookAt(player);
            transform.position = Vector3.MoveTowards(transform.position, player.position, velocity);
        }
    }
}
