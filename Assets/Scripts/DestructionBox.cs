using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionBox : MonoBehaviour
{
    public GameObject instanc;
    public bool isActive = true;
    // public bool isRespawn = false;
    // public Vector3 lastposition;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Destruction")
        {

            instanc = other.gameObject;
            instanc.SetActive(false);
            isActive = false;
        }
    }


    void Update()
    {
        if (isActive == false)
        {
            //Debug.Log("bandera");
            //StartCoroutine(ImACoroutine());
            StartCoroutine(TimeDelay());
            ReturnBox();
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
