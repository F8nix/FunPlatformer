using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoCredits : MonoBehaviour
{
    public void ChangeSceneToEndScreen() {
        SceneManager.LoadScene("EndScreen");
    }
    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "Player"){
            ChangeSceneToEndScreen();
        }
    }
}
