using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    void Start(){
        Time.timeScale = 1;
    }

    public void FlappyBird(){
        SceneManager.LoadScene(1);
    }

    public void Menu(){
        SceneManager.LoadScene(0);
    }

    public void ItemDrop(){
        SceneManager.LoadScene(2);
    }

    public void SkyJump()
    {
        SceneManager.LoadScene(3);
    }

    public void ColorsSw()
    {
        SceneManager.LoadScene(4);
    }

    public void Inicio()
    {
        SceneManager.LoadScene(5);
    }
}
