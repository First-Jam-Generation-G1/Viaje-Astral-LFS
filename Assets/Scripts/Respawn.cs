using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    public RespawnMove respawnMove;
    public bool isFail = false;

    public GameObject newPlayer;
    public GameObject cam;
    public GameObject camAux;

    public float groundDistance = 0.1f;
    public Transform groundCheck;
    public LayerMask groundMask;
    public Vector3 lastposition;
    public Quaternion lastRotation;
    public bool isRespawn = false;


    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        isFail = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isFail && isRespawn==false)
        {
            isRespawn = true;
            lastposition = player.transform.position;
            lastRotation = player.transform.rotation;

            player.SetActive(false);
            cam.SetActive(false);
            
            camAux.SetActive(true);
            newPlayer.SetActive(true);

            newPlayer.transform.position = lastposition;
            newPlayer.transform.rotation = lastRotation;

            respawnMove.Jump();
        }

        if (isRespawn == true && newPlayer.transform.position == respawnMove.origin.position)
        {
            newPlayer.SetActive(false);
            camAux.SetActive(false);

            cam.SetActive(true);
            player.SetActive(true);
            player.transform.position = respawnMove.origin.position;

            isRespawn = false;
        }

    }

}
