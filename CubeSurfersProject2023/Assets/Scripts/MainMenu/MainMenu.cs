using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HmsPlugin;
using HuaweiMobileServices;
using HuaweiMobileServices.Utils;
using HuaweiMobileServices.Id;

public class MainMenu : MonoBehaviour
{

   // HMSAdsKitManager.Instance.LoadAllAds();

   public void ExitButton()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        HMSAdsKitManager.Instance.ShowInterstitialAd();
    }
    /*
    public void SignIn()
    {
        HMSAccountKitManager.Instance.OnSignInSuccess = SignInSuccess;
        HMSAccountKitManager.Instance.OnSignInFailed = SignInFailed;
        HMSAccountKitManager.Instance.SignIn();
    }

    public void SignInSuccess(AuthAccount authAccount)
    {
        Debug.Log("OnLoginSuccess User Name:" + authAccount.DisplayName);
    }

    public void SignInFailed(HMSException exception)
    {
        Debug.Log("SignInFailed. Exception details :" + exception.Message);
    }
    */

    public void WatchAd()
    {
      //  HMSAdsKitManager.Instance.LoadBannerAd();
        HMSAdsKitManager.Instance.ShowBannerAd();
    }

    /*
    public void OnNoAdsClick()
    {
        HMSIAPManager.Instance.OnBuyProductSuccess = OnBuyProductSuccess;
        HMSIAPManager.Instance.BuyProduct(HMSIAPConstants.AdsRemove);
        MainMenu.Hide();
    }

    private void OnBuyProductSuccess(PurchaseResultInfo result)
    {
        if(result.InAppPurchaseData.ProductId == HMSIAPConstants.AdsRemove)
        {
            Debug.Log(" OnBuyProductSuccess ");
        }
    }
    */
}
