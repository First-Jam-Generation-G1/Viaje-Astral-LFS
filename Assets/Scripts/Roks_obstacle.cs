using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Roks_obstacle : MonoBehaviour
{
    public LayerMask layerPlayer;
    public bool isAlert;

    public GameObject[] rocks;
    public Vector3[] initialPositions;
    public bool rocksIsMove = false;
    public Respawn respawn;
    // Update is called once per frame
    void Update()
    {
        isAlert = Physics.CheckSphere(transform.position, 10, layerPlayer);

        if (isAlert && rocksIsMove == false)
        {
            rocksIsMove = true;
            for (int i = 0; i < rocks.Length; i++)
            {

                rocks[i].transform.position = initialPositions[i];
                rocks[i].SetActive(true);
            }
        }
        if (respawn.isRespawn)
        {
            rocksIsMove = false;
            for (int i = 0; i < rocks.Length; i++)
            {
                rocks[i].SetActive(false);
            }
        }
    }
}
