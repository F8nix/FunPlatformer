using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoGameplay : MonoBehaviour
{
    public void ChangeSceneToGameplay() {
        SceneManager.LoadScene("Gameplay");
    }
}
