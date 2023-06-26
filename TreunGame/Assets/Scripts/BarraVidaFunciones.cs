using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVidaFunciones : MonoBehaviour
{
    public Image Vida;
    public float VidaActual;
    public float VidaMaxima=100;

    private void Update() {
        Vida.fillAmount = VidaActual/VidaMaxima;
    }
    public void HacerDaño(float daño){
        VidaActual-=daño;
        if(VidaActual<=0){
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
