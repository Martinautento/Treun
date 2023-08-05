/*
- Mueve las balas hacia arriba
- Destruye las balas
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBala : MonoBehaviour
{
    public float velocidad = 5;
    // GameObject que representa la bala.
    public GameObject Bala;
    // Variable para controlar el tiempo.
    float time = 0.0f;

    void Update()
    {
        // Mueve el objeto hacia arriba según la velocidad y el tiempo transcurrido desde el último fotograma.
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
        // Aumenta el tiempo según el tiempo transcurrido desde el último fotograma.
        time += Time.deltaTime;
        // Comprueba si el tiempo es mayor a 2 segundos.
        if(time>2){
            // Destruye el objeto "Bala".
            Destroy(Bala);
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
        // Comprueba si la etiqueta del objeto colisionado es "Dragon".
        if(collision.gameObject.tag == "Dragon"){
            // Destruye el objeto "Bala".
            Destroy(Bala);
        }
    }
}
