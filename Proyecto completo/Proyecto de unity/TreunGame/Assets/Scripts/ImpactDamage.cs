/*
- Detecta las colisiones de las balas con los dragones
- Desactiva los dragones al morir
- Llama a la funcion que modifica al contador
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpactDamage : MonoBehaviour
{
    public int vidaDragon = 10;
    // Componente AudioSource asociado al objeto.
    private AudioSource audioSource;
    
    private void Start() {
        // Obtiene el componente AudioSource adjunto al objeto y lo asigna a "audioSource".
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Bala"){
            // Reduce la vida del dragón y llama a la función "killDragon" para verificar si el dragón debe ser eliminado.
            vidaDragon--;
            killDragon(vidaDragon);
        }else if(collision.gameObject.tag == "Patito"){
            // Reduce la vida del dragón en 2 y llama a la función "killDragon" para verificar si el dragón debe ser eliminado.
            vidaDragon-=2;
            killDragon(vidaDragon);
        }
    }
    // Corutina que se ejecuta para hacer reaparecer al dragón después de cierto tiempo.
    IEnumerator RespawnDragon(){
        // Espera 20 segundos antes de realizar el respawn del dragón.
        yield return new WaitForSeconds(20);
        // Habilita el componente SpriteRenderer y el Collider2D del dragón.
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
        // Restablece la vida del dragón a 10.
        vidaDragon=10;
    }

    // Función para verificar si el dragón debe ser eliminado.
    public void killDragon(int vida){
        // Comprueba si la vida del dragón es igual o menor a 0.
        if(vida<=0){
            // Deshabilita el componente SpriteRenderer y el Collider2D del dragón.
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            // Reproduce el audio asociado al dragón.
            audioSource.Play();
            // Aumenta el contador de un valor estático "x".
            AumentarContador.x++;
            // Inicia la corutina para hacer respawn del dragón después de un tiempo determinado.
            StartCoroutine(RespawnDragon());
        }
    }
}