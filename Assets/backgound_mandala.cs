using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgound_mandala : MonoBehaviour
{
    public Vector3 RotateAmount;  // degrees per second to rotate in each axis. Set in inspector.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount * Time.deltaTime * 0.5f);
    }

    public void loadScene(string sneneName)
    {
        SceneManager.LoadScene(sneneName);
    }
}
