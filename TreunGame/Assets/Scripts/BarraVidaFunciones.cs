using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVidaFunciones : MonoBehaviour
{
    private Slider slider;

    private void Start() {
        slider = GetComponent<Slider>();
    }

    public void CambiarVidaMax(float VidaMax){
        slider.maxValue = VidaMax;
    }
    public void CambiarVidaActual(float cantidadVida){
        slider.value = cantidadVida;
    }

    public void InicializarBarraVida(float cantidadVida){
        CambiarVidaMax(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }
}
