using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int health;
    public int Health {get; set;}
    private void Start() {
        Health = 3;
    }
    public void ChangeHealth(int amount) {
        Health += amount;
        //to spr i ten Health nic nie psuje
        if (Health == 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        Debug.Log(Health);
    }
}
