using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    //switching scenes by scene index
    public void ChangeScenes(string scene)
    {
            SceneManager.LoadScene(scene);
    }
}
