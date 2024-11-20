using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables de referencia privada
    private float horInput; //Referencia al input horizontal del teclado
    private float verInput; //Referencia al input vertical del teclado

    [Header("General References")]
    public Rigidbody playerRb; //Almacén del Rigidbody del player. Me permite moverlo
    public AudioSource playerAudio; //Referencia al reproductor de sonidos del player
    public float puntosBackflip; //Almacena los puntos que consigues haciendo backflips

    [Header("Movement Variables")]
    public float speed;

    [Header("Jump Variables")]
    public float jumpForce;
    public bool isGrounded;
    public bool hasSaltado; //controla si el motivo por el que estas en el aire es un salto o no

    [Header("Sound Library")]
    public AudioClip[] soundLibrary; //"Estantería" de sonidos del player

    [Header("Respawn Configuration")]
    public GameObject respawnPoint; //Ref al objeto que marca el punto de respawn (transform)
    public float fallLimit; //Valor en -y que al alcanzarlo se ejecutará el respawn

    public bool En_el_Tobogan;


    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
    }

    //Controlar si estas o no en contacto con el tobogan para reaparecer o Hacer Backflips

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Tobogan"))
        {
            Respawn();
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Almacenar de manera constante el input de teclado en los ejes X e Y
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");
        Jump();
        if (isGrounded == false && hasSaltado == false)
        {
            puntosBackflip = puntosBackflip + 0.1f;
            Debug.Log(puntosBackflip);
        }
    }

    private void FixedUpdate()
    {
        //Aquí se codea/llama a acciones que dependan de la física CONSTANTE
        //VelocityMove();
        ForceMove();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            hasSaltado = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            playerAudio.PlayOneShot(soundLibrary[2]);
        }
    }

    void VelocityMove()
    {
        //Movimiento basado en afectar al velocity: "Motor" que imita la capacidad de moverse de un ser vivo
        playerRb.velocity = new Vector3(horInput * speed, playerRb.velocity.y, verInput * speed);
    }

    void ForceMove()
    {
        //Movimiento basado en aplicar fuerza de empuje en dos ejes: X/Z
        playerRb.AddForce(Vector3.right * horInput * speed);
        playerRb.AddForce(Vector3.forward * verInput * speed);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            playerAudio.PlayOneShot(soundLibrary[0]);
            isGrounded = false;
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasSaltado = true;
        }
    }

    void Respawn()
    {
        playerRb.velocity = new Vector3(0, 0, 0);
        playerAudio.PlayOneShot(soundLibrary[1]);
        //Cambia la posición del player por la posición del punto de respawn
        transform.position = respawnPoint.transform.position;
    }


}
