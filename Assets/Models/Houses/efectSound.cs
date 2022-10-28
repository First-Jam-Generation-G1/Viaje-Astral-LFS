using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectSound : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D c){
        if(c.CompareTag("Player")){
            audioSource.Play();
        }
    }
}
