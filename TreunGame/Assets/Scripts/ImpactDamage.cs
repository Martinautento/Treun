using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactDamage : MonoBehaviour
{
    public int vidaDragon = 10;
    //public int contador=0;

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
        yield return new WaitForSeconds(30);
        GetComponent<SpriteRenderer>().enabled = true;
        vidaDragon=10;
    }

    public void killDragon(int vida){
        if(vida<=0){
            GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(RespawnDragon());
            //aumentar contador en uno
        }
    }
}