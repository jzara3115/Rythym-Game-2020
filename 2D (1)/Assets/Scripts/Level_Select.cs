using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Select : MonoBehaviour
{

    public void level1()
    {
        Debug.Log("Level 1");
        SceneManager.LoadScene("Game Scene");
    }

}
