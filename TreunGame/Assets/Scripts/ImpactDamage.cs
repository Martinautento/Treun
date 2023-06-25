using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpactDamage : MonoBehaviour
{
    public int vidaDragon = 10;
    private AudioSource audioSource;
    public int x = 0; // Variable pública para el contador
    public Text textoContador; // Referencia al objeto Text de UI
    
    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Bala"){
            vidaDragon--;
            killDragon(vidaDragon);
        }else if(collision.gameObject.tag == "Patito"){
            vidaDragon-=2;
            killDragon(vidaDragon);
        }
    }
    // Método para actualizar el texto del contador
    private void ActualizarContador()
    {
        textoContador.text = x.ToString() + "/100";
    }

    // Método para aumentar el contador en uno
    public void AumentarContador(){
        if (x < 100)
        {
            x++;
            ActualizarContador();
        }
    }
    IEnumerator RespawnDragon(){
        yield return new WaitForSeconds(20);
        GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<Collider2D>().enabled = true;
        vidaDragon=10;
    }

    public void killDragon(int vida){
        if(vida<=0){
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            audioSource.Play();
            StartCoroutine(RespawnDragon());
            AumentarContador();
        }
    }
}