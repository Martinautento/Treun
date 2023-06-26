using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpactDamage : MonoBehaviour
{
    public int vidaDragon = 10;
    private AudioSource audioSource;
    
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
    IEnumerator RespawnDragon(){
        yield return new WaitForSeconds(20);
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
        vidaDragon=10;
    }

    public void killDragon(int vida){
        AumentarContador.x++;
        if(vida<=0){
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            audioSource.Play();

            StartCoroutine(RespawnDragon());
        }
    }
}