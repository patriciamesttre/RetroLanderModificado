using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class telaintro : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
