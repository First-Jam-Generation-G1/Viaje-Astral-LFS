using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float runSpeed = 3;
    public float rotationSpeed = 150;

    public Animator animatior;
    public Rigidbody rigidbody;

    public float jumpHeight = 1.5f;
    public float groundDistance = 0.1f;
    public Transform groundCheck;
    public LayerMask groundMask;

    bool isGrounded;

    private float x, y;

    //Variables para el sonido de pasos del jugador
    public AudioSource walk;
    private bool HActive; //Verificación si soltó o no la tecla
    private bool VActive; //Verificación si soltó o no la tecla

    //Variable para sonido de salto del jugador
    public AudioClip jumpSound; //Cuando salta
    public AudioClip fallingSound; //Cuando Cae

    public Vector2 turn;

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
    }


    public void Dead()
    {
        animatior.SetBool("Other", false);
        animatior.Play("Fail");
    }
    public void Walk()
    {
        x = Input.GetAxis("Horizontal");
        //x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Vertical");


        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);

        animatior.SetFloat("VelX", x);
        animatior.SetFloat("VelY", y);

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
    public void Jump()
    {
        // Determina si hay otros movimientos en curso
        if (x > 0 || x < 0 || y > 0 || y < 0)
        {
            animatior.SetBool("Other", true);
        }
        //Determina si esta en el piso, todos los elementos que sean suelo deberan tener la mascara "Floor"
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        // Salto
        if (Input.GetKeyDown("space") && isGrounded)
        {
            animatior.Play("Jumping Up");
            Invoke("Jump_", 1/5);
            walk.PlayOneShot(jumpSound);
        }


        else if (Input.GetKeyUp("space"))
        {
            walk.PlayOneShot(fallingSound);
        }
    }

    public void Jump_()
    {
        rigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
    }

}
