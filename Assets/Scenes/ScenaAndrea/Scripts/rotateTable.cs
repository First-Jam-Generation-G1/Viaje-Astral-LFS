using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTable : MonoBehaviour
{   
    public Vector3 rotationChanges;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationChanges);
    }
}
