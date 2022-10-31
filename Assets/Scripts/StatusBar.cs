using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour
{

    public Image consciousnessBar;

    public float currentConsciousness = 0;
    public float maxConsciousness;

    // Update is called once per frame
    void Update()
    {
        consciousnessBar.fillAmount = currentConsciousness / maxConsciousness;
    }
}
