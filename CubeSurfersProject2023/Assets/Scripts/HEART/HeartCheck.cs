using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HmsPlugin;
using HuaweiMobileServices;
using HuaweiMobileServices.Utils;
using HuaweiMobileServices.Id;

public class HeartCheck : MonoBehaviour
{
    //public float timeValue = 180;
    
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject[] hearts = new GameObject[3];
    public static int can=3;
    public int max_can=3;
    public GameObject StartButton;
    // Update is called once per frame
    void Start()
    {
        
        heart1 = GameObject.FindWithTag("heart1");
        heart2 = GameObject.FindWithTag("heart2");
        heart3 = GameObject.FindWithTag("heart3");
        
        GameObject[] hearts= { heart1,heart2,heart3};
        StartButton = GameObject.FindWithTag("startButton");
        StartButton.SetActive(true);
        heartSystem();
    }

    void Update()
    {
        //StartButton.onClick.AddListener(heart_decrease);

        if (can == 0)
        {
            StartButton.SetActive(false);
        }
        else { StartButton.SetActive(true);}
    }

    public void heart_increase()
    {
        can++;
        heartSystem();
    }

    public void WatchAd()
    {
        //  HMSAdsKitManager.Instance.LoadBannerAd();
        HMSAdsKitManager.Instance.LoadRewardedAd();
        heart_increase();
    }

    public void healing()
    {

    }

    public void heart_decrease()
    {
        can--;
        heartSystem();
    }

    void heartSystem()
    {
        for(int i=0; i<max_can; i++)
        {
            hearts[i].SetActive(false);
        }
        for(int i=0; i<can; i++)
        {
            hearts[i].SetActive(true);
        }
    }



    /*
    public void heart_timer()
    {
        while (1)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue += 180;
                heart_increase();
            }
        }
    }
    */
}
