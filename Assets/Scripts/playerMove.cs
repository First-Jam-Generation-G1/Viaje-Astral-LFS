using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    //Variables para el sonido de pasos del jugador
    public AudioSource walk;
    private bool HActive; //Verificación si soltó o no la tecla
    private bool VActive; //Verificación si soltó o no la tecla

    public Vector2 turn;

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    public void Walk()
    {
        //Validación (Oprimió o no las teclas -> Reproduce o no sonido)        
        if (Input.GetButtonDown("Horizontal"))
        { //Si oprime la tecla, reproduzca sonido
            HActive = true; //Valida que si esté presionada
            walk.Play();
        }
        if (Input.GetButtonDown("Vertical"))
        { //Si oprime la tecla, reproduzca sonido
            VActive = true; //Valida que si esté presionada
            walk.Play();
        }
        if (Input.GetButtonUp("Horizontal"))
        { //Si no oprime la tecla, pause sonido
            HActive = false; //Valida que no esté presionada
            if (VActive == false)
            {
                walk.Pause();
            }
        }
        if (Input.GetButtonUp("Vertical"))
        { //Si no oprime la tecla, pause sonido
            VActive = false; //Valida que no esté presionada
            if (HActive == false)
            {
                walk.Pause();
            }
        }
    }
}
