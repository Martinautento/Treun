using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    public GameObject balaFuego;
    public Transform controladorDisparo;
    Rigidbody2D rb2D;
    public bool disparo;
    [SerializeField] int time;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        disparo = true;
        StartCoroutine(EsperaDisparo());
    }

    void FixedUpdate(){
        if(disparo==false){
            disparo = true;
            if(gameObject.tag == "Dragon"){
                StartCoroutine(EsperaDisparoBebe());
            }else{
                StartCoroutine(EsperaDisparo());
            }
            Disparo();
        }
    }

    IEnumerator EsperaDisparo(){
        yield return new WaitForSeconds(15);
        disparo = false;
    }

    IEnumerator EsperaDisparoBebe(){
        yield return new WaitForSeconds(time);
        disparo = false;
    }

    public void Disparo(){
        //modificar la rotacion de la bala en un angulo entre 0 y 45 aleatorio
        Instantiate(balaFuego, controladorDisparo.position, controladorDisparo.rotation);
    }
}
