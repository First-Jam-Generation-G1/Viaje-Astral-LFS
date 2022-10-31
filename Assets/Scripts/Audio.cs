using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    public AudioSource start;
    // Start is called before the first frame update
    void Start()
    {
        start.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey || !start.isPlaying)
        {
            start.Stop();
            SceneManager.LoadScene("Andrea");
        }
    }
}
