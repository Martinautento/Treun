using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float runSpeed = 2f;
    public static bool isPaused = false;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject[] balas;
    [SerializeField] private int TipoBala = 1;
    [SerializeField] private float TiempoDisparo = 0.4f;
    [SerializeField] private bool disparo;
    [SerializeField] private int numeroAleatorio;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip patos;
    [SerializeField] private AudioClip flecha;
    [SerializeField] private Animator animator; // El componente animator que está dentro del objeto jugador
    [SerializeField] private GameObject menuPausa;

    void Start()
    {
        // Inicialización de variables y referencias
        rb2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        Time.timeScale = 1f;
        animator = GetComponent<Animator>(); // Referenciamos el componente Animator del objeto Jugador
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKey("p"))
        {
            TogglePause();
        }
        // Movimiento del jugador
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            animator.SetBool("Walk", true);
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            animator.SetBool("Walk", true);
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
        }
        else
        {
            animator.SetBool("Walk", false);
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

        // Disparo
        if ((Input.GetKey("e") || Input.GetKey("space")) && !disparo)
        {
            animator.SetBool("Walk", true);
            disparo = true;
            StartCoroutine(EsperaDisparo());
            Disparo(TipoBala);
            if (TipoBala == 1)
            {
                audioSource.PlayOneShot(flecha);
            }
            else
            {
                audioSource.PlayOneShot(patos);
            }
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Pausa el tiempo del juego
            menuPausa.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f; // Reanuda el tiempo del juego
            menuPausa.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Manejo de colisiones
        if (collision.CompareTag("Botas"))
        {
            numeroAleatorio = Random.Range(0, 6);
            runSpeed = (numeroAleatorio <= 3) ? 0.5f : 5.5f;
            StartCoroutine(TemporizadorBotas());
        }
        else if (collision.CompareTag("Pato"))
        {
            TipoBala = 0;
            TiempoDisparo = 0.2f;
            StartCoroutine(TemporizadorPatos());
        }
    }

    // Corrutina para el temporizador de las botas
    IEnumerator TemporizadorBotas()
    {
        yield return new WaitForSeconds(15);
        runSpeed = 2;
    }

    // Corrutina para el temporizador de los patos
    IEnumerator TemporizadorPatos()
    {
        yield return new WaitForSeconds(15);
        TipoBala = 1;
        TiempoDisparo = 0.4f;
    }

    // Corrutina para el temporizador del disparo
    IEnumerator EsperaDisparo()
    {
        yield return new WaitForSeconds(TiempoDisparo);
        disparo = false;
    }

    // Método para manejar el disparo
    public void Disparo(int bala)
    {
        Instantiate(balas[TipoBala], controladorDisparo.position, controladorDisparo.rotation);
    }
}
