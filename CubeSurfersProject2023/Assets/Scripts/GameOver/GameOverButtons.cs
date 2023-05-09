using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void RetryForDesert()
    {
        SceneManager.LoadScene("Game");
    }
    public void RetryForOcean()
    {
        SceneManager.LoadScene("OceanStage");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
