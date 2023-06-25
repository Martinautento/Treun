using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AumentarContador : MonoBehaviour
{
    public int x = 0;
    public Text textoContador;

    // Método para actualizar el texto del contador
    private void ActualizarContador()
    {
        textoContador.text = x.ToString() + "/100";
    }

    // Método para aumentar el contador en uno
    public void ModificarContador(){
        if (x < 100)
        {
            x++;
            ActualizarContador();
        }
    }
}