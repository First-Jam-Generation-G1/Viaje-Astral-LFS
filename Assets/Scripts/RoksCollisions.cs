using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoksCollisions : MonoBehaviour
{
    public bool isTouch;
    public LayerMask layeRock;
    public Respawn Respawn;

    // Update is called once per frame
    void Update()
    {
        isTouch = Physics.CheckSphere(transform.position, 1, layeRock);
        if (isTouch) {
            Respawn.isTaouch = true;
        }
    }


}
