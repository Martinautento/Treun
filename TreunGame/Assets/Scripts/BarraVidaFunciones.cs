/*
- Se encarga de modificar la barra de vida
- Detecta cuando las bolas de fuego hacen daño al jugador
- Detecta cuando mueres y suelta el menu correspondiente
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BarraVidaFunciones : MonoBehaviour
{
    //Declaracion de variables
    public Image Vida;
    public float VidaActual;
    public float VidaMaxima=100;
    public event EventHandler MuerteJugador; // Evento que se dispara cuando el jugador muere.

    private void Update() {
        //va actualizando la barra de vida a cda rato
        Vida.fillAmount = VidaActual/VidaMaxima;
    }
    // Método para aplicar daño al jugador.
    public void HacerDaño(float daño){
        // Reduce la vida actual del jugador según el valor de "daño".
        VidaActual-=daño;
        // Comprueba si la vida actual es menor o igual a cero, lo que indica que el jugador ha muerto.
        if(VidaActual<=0){
            // Dispara el evento MuerteJugador, notificando que el jugador ha muerto.
            MuerteJugador?.Invoke(this, EventArgs.Empty);
            //Destruye el objeto
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "BolaFuegoNormal"){
            HacerDaño(4);
        }else if(collision.gameObject.tag == "BolaFuego"){
            HacerDaño(10);
        }
    }
}
