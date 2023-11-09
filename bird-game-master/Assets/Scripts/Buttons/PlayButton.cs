using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public int gameSceneNumber;

    public void PlayGame()
    {
        SceneManager.LoadScene(gameSceneNumber);
    }
}
