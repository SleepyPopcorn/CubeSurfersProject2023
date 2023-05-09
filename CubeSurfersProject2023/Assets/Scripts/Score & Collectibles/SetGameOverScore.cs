using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetGameOverScore : MonoBehaviour
{

    public TMP_Text FinalGemScoreText;

    [SerializeField] public ScoreManager scoremanager;

    int FinalGemScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        FinalGemScore = scoremanager.Gems;

        FinalGemScoreText.text = "FINAL SCORE: " + (FinalGemScore * 10).ToString(); 
    }
}
