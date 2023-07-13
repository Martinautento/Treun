//falta comentar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    
    private AudioSource audioSource;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player")){
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.3f);
            audioSource.Play();
            
        }else if(collision.CompareTag("Finish")){
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.3f);
        }
    }
}
