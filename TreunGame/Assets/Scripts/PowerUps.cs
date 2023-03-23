using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player")){
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.5f);
        }else if(collision.CompareTag("Finish")){
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.5f);
        }
    }
}
