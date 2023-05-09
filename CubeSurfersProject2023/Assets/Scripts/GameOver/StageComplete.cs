using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void NextLevelDesert()
    {
        SceneManager.LoadScene("Game");
    }

    public void NextLevelOcean()
    {
        SceneManager.LoadScene("OceanStage");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
