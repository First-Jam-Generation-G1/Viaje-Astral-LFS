using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public float count = 0;
    public TextMeshProUGUI textTimerPro;

    void Update()
    {
        count -= Time.deltaTime;
        textTimerPro.text = "" + count.ToString("f0");
        if (count < 0)
        {
            textTimerPro.text = "XD";
        }

    }
}
