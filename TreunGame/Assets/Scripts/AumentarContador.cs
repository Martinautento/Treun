using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AumentarContador : MonoBehaviour
{
    public static int x = 0;
    Text textoContador;
    [SerializeField] private GameObject menuVictory;

    private void Start() {
        textoContador = GetComponent<Text>();
    }
    private void ActivarYouWIN(){
        menuVictory.SetActive(true);
        Time.timeScale = 0f;
    }
    private void Update() {
        if(x<100){
            textoContador.text = x + "/100";
        }else{
            textoContador.text = "100/100";
            ActivarYouWIN();
        }
    }
}