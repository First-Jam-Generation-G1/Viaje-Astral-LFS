using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    public RespawnMove respawnMove;
    public bool isFail = false;
    public bool isTaouch = false;

    public GameObject newPlayer;
    public GameObject cam;
    public GameObject camAux;

    public float groundDistance = 0.1f;
    public Transform groundCheck;
    public LayerMask groundMask;
    public Vector3 lastposition;
    public Quaternion lastRotation;
    public bool isRespawn = false;

    public EnemyMove enemy;
    public AudioSource retroceso_AS;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (isRespawn == false)
        {
            isFail = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        }

        if ((isTaouch || isFail) && isRespawn == false)
        {
            Invoke("RespawnFunction", 1/2);
            Debug.Log("isTouch: " + isTaouch + " isFail: " +isFail + " isRespawn: " + isRespawn);
        }

        if (isRespawn == true && newPlayer.transform.position == respawnMove.respawnPosition)
        {
            Input.GetKeyDown(KeyCode.LeftShift);
            isRespawn = false;
            isTaouch = false;

            newPlayer.SetActive(false);
            camAux.SetActive(false);
            retroceso_AS.Stop();
            respawnMove.velocity = 0.5f;

            cam.SetActive(true);
            player.SetActive(true);
            player.transform.position = respawnMove.respawnPosition;

            lastposition = respawnMove.respawnPosition;
            lastRotation = respawnMove.origin.rotation;
        }

    }

    void RespawnFunction()
    {
        retroceso_AS.Play();

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
        enemy.resetPosition();
    }
}
