using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallRock : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider c){
        if(c.CompareTag("Player")){
            audioSource.Play();
        }
    }
}
