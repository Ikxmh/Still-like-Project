using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // an variable to store the value of the scene index
    private int nextSceneIndex;
    private void Start()
    {
        // get the current scene and get ready to load up next scene
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        // once it detected the player, it'll load the next scene
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
