using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConscience : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isTouch;
    public LayerMask layerPlayer;
    public StatusBar statusBar;
    public float consciousnessLevel;

    // Update is called once per frame
    void Update()
    {
        isTouch = Physics.CheckSphere(transform.position, 5, layerPlayer);
        if (isTouch)
        {
            statusBar.currentConsciousness = consciousnessLevel;
        }
    }
}
