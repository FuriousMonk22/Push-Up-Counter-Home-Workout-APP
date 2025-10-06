using GoogleMobileAds.Api;
using System;
using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

class AdMobManager : MonoBehaviour
{
    // Replace these IDs with your IDs vom https://admob.google.com/home/ 
    // These are just Test IDs
#if UNITY_IOS
    private string BannerID = "ca-app-pub-3940256099942544/2934735716";
    private string InterstitialAdID = "ca-app-pub-3940256099942544/4411468910";
    private string RewardedAdID = "ca-app-pub-3940256099942544/1712485313";
#elif UNITY_ANDROID
    private string BannerID = "ca-app-pub-3940256099942544/6300978111";
    private string InterstitialAdID = "ca-app-pub-3940256099942544/1033173712";
    private string RewardedAdID = "ca-app-pub-3940256099942544/5224354917";
#endif
    /*
    // TEST ADS:
#if UNITY_IOS
    private string BannerID = "ca-app-pub-7065132953112061/9654571153";
    private string InterstitialAdID = "ca-app-pub-7065132953112061/6300637749";
    private string RewardedAdID = "ca-app-pub-7065132953112061/8724632861";
#elif UNITY_ANDROID
    private string BannerID = "ca-app-pub-7065132953112061/9654571153";
    private string InterstitialAdID = "ca-app-pub-7065132953112061/6300637749";
    private string RewardedAdID = "ca-app-pub-7065132953112061/8724632861";
#endif
    */


    private BannerView banner;
    private InterstitialAd interstitialAd;
    private RewardedAd rewardedAd;

    private AdsManager adsManager;

    //public Button resumebutton;
    //public Button pausebutton;

    public void Initialize()
    {
        MobileAds.Initialize(initStatus => { });
        CreateBanner();
        CreateInterstitial();
        CreateRewarded();
        RequestBanner();
        RequestInterstitialAd();
        //RequestRewardedAd();
    }


    private void CreateBanner()
    {
        banner = new BannerView(BannerID, AdSize.Banner, AdPosition.Top);
        banner.OnAdFailedToLoad += HandleOnAdFailedToLoad;
    }

    private void CreateInterstitial()
    {
        interstitialAd = new InterstitialAd(InterstitialAdID);
        interstitialAd.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        interstitialAd.OnAdClosed += HandleOnAdClosed;
    }

    private void CreateRewarded()
    {
        rewardedAd = new RewardedAd(RewardedAdID);
        rewardedAd.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        rewardedAd.OnAdClosed += HandleOnAdClosed;
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }



    private void RequestBanner()
    {
        CreateBanner();
        AdRequest request = new AdRequest.Builder().Build();
        banner.LoadAd(request);
    }

    private void RequestInterstitialAd()
    {
        AdRequest request = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(request);
    }

    private void RequestRewardedAd()
    {
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
    }


    public void ShowBanner()
    {
        if (banner != null)
        {
            banner?.Show();
        }
    }

    public void HideBanner()
    {
        banner?.Hide();
    }

    public void ShowBannerDelayed()
    {
        StartCoroutine(BannerShowDelay(0.5f));
    }

    public void HideBannerDelayed()
    {
        StartCoroutine(BannerHideDelay(0.5f));
    }

    public void ShowInterstitialAd()
    {
        if (interstitialAd.IsLoaded())
        {
            interstitialAd.Show();
        }
    }

    public void ShowRewardedAd()
    {
        //CreateBanner();
        RequestRewardedAd();
    }

    public void HideAllBanners()
    {
        if (banner != null)
        {
            banner.Hide();
            banner.Destroy();
            StartCoroutine(BannerRequestDelay(0f));
        }
    }

    public void HideAllBannersNoDelay()
    {
        if (banner != null)
        {
            banner.Hide();
            banner.Destroy();
            RequestBanner();
        }
    }

    public void DestroyBanners()
    {
        if (banner != null)
        {
            banner.Hide();
            banner.Destroy();
            RequestBanner();
            StartCoroutine(BannerHideDelay(0.2f));
        }
    }

    private void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        Debug.LogError("Something went wrong, " + sender + " couldn't load ");
        //ShowBanner();
        adsManager.EnableTipButton();
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        rewardedAd.Show();
        adsManager.EnableTipButton();
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        AdsManager.instance.RewardedAdFinished();
    }

    private void HandleOnAdClosed(object sender, EventArgs args)
    {
        RequestInterstitialAd();
        //adsManager.EnableTipButton();
        //ShowBanner();
        //HideAllBanners();
    }

    private IEnumerator BannerRequestDelay(float time)
    {
        yield return new WaitForSeconds(time);
        RequestBanner();
    }
    private IEnumerator BannerHideDelay(float time)
    {
        //resumebutton.interactable = false;
        //pausebutton.interactable = false;
        yield return new WaitForSeconds(time);
        banner.Hide();
        //resumebutton.interactable = true;
        //pausebutton.interactable = true;
    }

    private IEnumerator BannerShowDelay(float time)
    {
        //resumebutton.interactable = false;
        //pausebutton.interactable = false;
        yield return new WaitForSeconds(time);
        ShowBanner();
        //resumebutton.interactable = true;
        //pausebutton.interactable = true;
    }

}