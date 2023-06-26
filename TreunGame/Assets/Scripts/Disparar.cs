using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    // Transform que indica la posición y rotación desde donde se dispara.
    public Transform controladorDisparo;
    // Array de GameObjects que representa las diferentes balas disponibles para el disparo.
    public GameObject[] balas;

    void Update(){
        // Comprueba si se presiona la tecla "e" o la barra espaciadora.
        if(Input.GetKey("e")||Input.GetKey("space")){
            // Realiza el disparo llamando al método "Disparo".
            Disparo();
        }
    }

    public void Disparo(){
        // Instancia un objeto aleatorio del array de balas en la posición y rotación del controlador de disparo.
        Instantiate(balas[Random.Range(0,balas.Length)], controladorDisparo.position, controladorDisparo.rotation);
    }
}
