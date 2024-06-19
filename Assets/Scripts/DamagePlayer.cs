using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public PlayerHealth playerHealthRef;
    public int amount;
    
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("I damaged");
        if(other.gameObject.tag == "Player"){
            playerHealthRef.ChangeHealth(-amount);
        }
    }
}
