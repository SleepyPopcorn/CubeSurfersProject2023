using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] public MC_CubeCountControl mc_cubecountcontrol;

    public TMP_Text GemScoreText;
    public TMP_Text CubeScoreText;
    private bool isThereInstance = false;

    [SerializeField] int Gems = 0;
    [SerializeField] int Cubes = 0;

    private void Awake()
    {
            if(isThereInstance == false)
            instance = this;
            isThereInstance = true;
    }

    void Start()
    {
        GemScoreText.text = "SCORE: " + Gems.ToString();
    }

    void Update()
    {

    }

    public void SetCubeScore()
    {   
            
            Cubes = mc_cubecountcontrol.cubeList.Count;
            PlayerPrefs.SetInt("FinalScore", (Cubes * 10) + (Gems * 10));
            gameObject.SetActive(false);

    }

    public void AddGemScore()
    {
        if (isThereInstance == true)
        {
        Gems += 1;
        GemScoreText.text = "SCORE: " + (Gems * 10).ToString();
        PlayerPrefs.SetInt("FinalScore", (Cubes * 10) + (Gems * 10));
        }
    }
    /*public void AddCubeScore()
    {
        Cubes += 1;
        PlayerPrefs.SetInt("FinalScore", (Cubes * 10) + (Gems * 10));
    }

    public void DecreaseCubeScore()
    {
        Cubes -= 1;
        PlayerPrefs.SetInt("FinalScore", (Cubes * 10) + (Gems * 10));
    }*/
   
}