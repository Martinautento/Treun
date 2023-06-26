using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AumentarContador : MonoBehaviour
{
    public static int x = 0;
    Text textoContador;

    private void Start() {
        textoContador = GetComponent<Text>();
    }
    private void Update() {
        textoContador.text = x + "/100";
    }
}