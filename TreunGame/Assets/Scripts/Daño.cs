/*
- Inicializa las bolas de fuego de los dragones
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    // Declaración de una variable pública que representa un GameObject llamado "balaFuego".
    public GameObject balaFuego;
    // Referencia al punto de control para el disparo de la bala de fuego.
    public Transform controladorDisparo;
    // Componente Rigidbody2D asociado al objeto.
    Rigidbody2D rb2D;
    public bool disparo;
    // Tiempo de espera para el próximo disparo. Varía segun cada dragon
    [SerializeField] int time;

    void Start()
    {
        // Obtiene el componente Rigidbody2D adjunto al objeto y lo asigna a "rb2D".
        rb2D = GetComponent<Rigidbody2D>();
        // Establece la variable "disparo" en true.
        disparo = true;
        // Inicia una corutina para controlar el tiempo de espera entre disparos.
        StartCoroutine(EsperaDisparo());
    }

    void FixedUpdate(){
        // Comprueba si se puede realizar un disparo.
        if(disparo==false){
            // Establece "disparo" en true y comienza una corutina de espera dependiendo de la etiqueta del objeto.
            disparo = true;
            if(gameObject.tag == "Dragon"){
                StartCoroutine(EsperaDisparoBebe());
            }else{
                StartCoroutine(EsperaDisparo());
            }
            // Realiza el disparo llamando al método "Disparo".
            Disparo();
        }
    }

    // Corutina para esperar un tiempo determinado antes de permitir el próximo disparo.
    IEnumerator EsperaDisparo(){
        // Espera 15 segundos antes de establecer "disparo" en false.
        yield return new WaitForSeconds(15);
        disparo = false;
    }
    // Corutina para esperar un tiempo determinado (dependiendo del valor de "time") antes de permitir el próximo disparo.
    IEnumerator EsperaDisparoBebe(){
        // Espera el tiempo especificado en "time" antes de establecer "disparo" en false.
        yield return new WaitForSeconds(time);
        disparo = false;
    }

    // Método para realizar el disparo.
    public void Disparo(){
        // Instancia un objeto "balaFuego" en la posición y rotación del controlador de disparo.
        Instantiate(balaFuego, controladorDisparo.position, controladorDisparo.rotation);
    }
}
