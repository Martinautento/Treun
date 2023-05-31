using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void EscenaJuego(){
        SceneManager.LoadScene("Juego");
    }
    public void EscenaCreditos(){
        SceneManager.LoadScene("Creditos");
    }
    public void BackToMenu(){
        SceneManager.LoadScene("Menu");
    }
}
