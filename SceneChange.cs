using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UntiyEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;
    void OnTriggerEnter(){
        EditorSceneManager.LoadScene(sceneName);
    }
}
