using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BarraVidaFunciones : MonoBehaviour
{
    public Image Vida;
    public float VidaActual;
    public float VidaMaxima=100;
    public event EventHandler MuerteJugador;

    private void Update() {
        Vida.fillAmount = VidaActual/VidaMaxima;
    }
    public void HacerDaño(float daño){
        VidaActual-=daño;
        if(VidaActual<=0){
            MuerteJugador?.Invoke(this, EventArgs.Empty);
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
