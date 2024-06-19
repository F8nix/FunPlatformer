using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApp : MonoBehaviour
{
    public void ExitAppFunc() {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit()
        #endif
    }
}