using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetFinalScore : MonoBehaviour
{
    public TMP_Text EndScoreText;

    int FinalScore = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        FinalScore = PlayerPrefs.GetInt("FinalScore",0);

        EndScoreText.text = "FINAL SCORE: " + FinalScore.ToString();
    }

}
