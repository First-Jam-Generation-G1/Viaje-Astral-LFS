using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("final", 3);
            SceneManager.LoadScene("Trivia");
        }
    }
    //Application.LoadLevel("Trivia");
    // Start is called before the first frame update

}
