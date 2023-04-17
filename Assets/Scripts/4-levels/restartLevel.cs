using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class restartLevel : MonoBehaviour
{
    [SerializeField] string sceneName;


         public void restartLevelfunc()
    {
        SceneManager.LoadScene(sceneName);

    }
}
