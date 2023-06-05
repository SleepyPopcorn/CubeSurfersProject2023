using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HmsPlugin;
using HuaweiMobileServices;
using HuaweiMobileServices.Utils;
using HuaweiMobileServices.Id;

public class StageComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void NextLevelDesert()
    {
        HMSAdsKitManager.Instance.ShowInterstitialAd();
        SceneManager.LoadScene("Game");
    }

    public void NextLevelOcean()
    {
        HMSAdsKitManager.Instance.ShowInterstitialAd();
        SceneManager.LoadScene("OceanStage");
    }

    public void MainMenu()
    {
        HMSAdsKitManager.Instance.ShowInterstitialAd();
        SceneManager.LoadScene("MainMenu");
    }
}
