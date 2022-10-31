using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionBox : MonoBehaviour
{
    public GameObject instanc;
    public bool isActive = true;
    public bool isTouch = false;
    public LayerMask playerLayer;
    // public bool isRespawn = false;
    // public Vector3 lastposition;
    // Start is called before the first frame update

    void Update()
    {
        if (isActive == false)
        {
            //Debug.Log("bandera");
            //StartCoroutine(ImACoroutine());
            StartCoroutine(TimeDelay());
            ReturnBox();
        }
        isTouch = Physics.CheckSphere(transform.position, 1, playerLayer);
        if (isTouch)
        {
            gameObject.SetActive(false);
            isTouch = false;
        }
    }
    public void ReturnBox()
    {
        //fuu = other.gameObject;
        instanc.gameObject.SetActive(true);
        isActive = true;
    }




    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log(Time.frameCount);
    }

}
