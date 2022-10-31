using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float sphereRadiusVision;
    public LayerMask layerPlayer;
    public Transform player;
    public bool isAlert;
    public bool touchPlayer;
    public float velocity = 1f;

    public Respawn respawn;

    public Animator animatior;

    public PauseMenu pauseMenu;
    public bool canMove = true;


    // Update is called once per frame
    void Update()
    {
        animatior.Play("Floating");
        isAlert = Physics.CheckSphere(transform.position, sphereRadiusVision, layerPlayer);


        touchPlayer = Physics.CheckSphere(transform.position, 0.5f, layerPlayer);

        if (isAlert && pauseMenu.isPaused == false && canMove)
        {
            transform.LookAt(player);
            transform.position = Vector3.MoveTowards(transform.position, player.position, velocity);
        }

        if (touchPlayer)
        {
            respawn.isTaouch = true;
        }


    }

    public void resetPosition()
    {
        transform.position = new Vector3(0, 2, 0);

    }
}
