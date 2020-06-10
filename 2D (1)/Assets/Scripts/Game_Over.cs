using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    private Player player;

void Awake()
{
    player = GameObject.FindObjectOfType<Player>();
}

    public void quit()
    {
        Application.Quit();
        Debug.Log("quit game");
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
