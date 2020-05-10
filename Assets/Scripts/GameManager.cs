using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetAxis("ESC")==1) {
            SceneManager.LoadScene(0);
        }
    }
}


