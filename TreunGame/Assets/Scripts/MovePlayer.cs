using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float runSpeed=2;
    Rigidbody2D rb2D;
    public Transform controladorDisparo;
    public GameObject[] balas;
    public int TipoBala = 1;
    public float TiempoDisparo = 0.4f;
    public bool disparo;
    public int numeroAleatorio;
    private AudioSource audioSource;
    [SerializeField] private AudioClip patos;
    [SerializeField] private AudioClip flecha;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        Time.timeScale = 1f;
    }

    void FixedUpdate()
    {
        if(Input.GetKey("d")||Input.GetKey("right")){
            rb2D.velocity = new Vector2(runSpeed,rb2D.velocity.y);
        }else if(Input.GetKey("a")||Input.GetKey("left")){
            rb2D.velocity = new Vector2(-runSpeed,rb2D.velocity.y);
        }else{
            rb2D.velocity = new Vector2(0,rb2D.velocity.y);
        }
        if((Input.GetKey("e")||Input.GetKey("space"))&&disparo==false){
            disparo = true;
            StartCoroutine(EsperaDisparo());
            Disparo(TipoBala);
            if(TipoBala==1){
                audioSource.PlayOneShot(flecha);
            }else{
                audioSource.PlayOneShot(patos);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Botas")){ 
            numeroAleatorio = Random.Range(0,6);
            if(numeroAleatorio<=3){
                runSpeed = 0.5f;
            }else{
                runSpeed = 5.5f;
            }
            StartCoroutine(TemporizadorBotas());
        }else if(collision.CompareTag("Pato")){
            TipoBala=0;
            TiempoDisparo = 0.2f;
            StartCoroutine(TemporizadorPatos());
        }
    }

    //la función sirve para crear corrutinas
    IEnumerator TemporizadorBotas(){
        yield return new WaitForSeconds(15);
        runSpeed = 2;
    }
    
    IEnumerator TemporizadorPatos(){
        yield return new WaitForSeconds(15);
        TipoBala=1;
        TiempoDisparo = 0.4f;
    }

    IEnumerator EsperaDisparo(){
        yield return new WaitForSeconds(TiempoDisparo);
        disparo = false;
    }

    public void Disparo(int bala){
        Instantiate(balas[TipoBala], controladorDisparo.position, controladorDisparo.rotation);
    }
}
