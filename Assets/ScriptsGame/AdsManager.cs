using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdsManager : MonoBehaviour
{
    public static AdsManager instance;

    private AdMobManager adMobManager;
    private string bannersShownKey = "bannersShown";
    private readonly int bannersShowForInterstitial = 16;

    public GameObject managerAds;
    public GameObject managerAds2;
    public Button tipbutton;
    public Button tipbutton2;
    public Button proButton;
    public Button proButton2;

    private void Awake()
    {
        SingletonPattern();
        adMobManager = gameObject.AddComponent<AdMobManager>();
        adMobManager.Initialize();
        PlayerPrefs.SetInt(bannersShownKey, 0);
    }

    public void Start()
    {
        if (PlayerPrefs.GetInt("VerifyPro") == 1)
        {
            HideBanners();
            tipbutton.interactable = false;
            proButton.interactable = false;
            proButton2.interactable = false;
            tipbutton2.interactable = false;
            Destroy(managerAds);
            Destroy(managerAds2);
        }
    }

    public void HideBanners()
    {
        if (!ShouldShowInterstitial())
            adMobManager.HideAllBanners();
        //adMobManager.DestroyBanners();
    }

    public void ShowInterstitialPerhabs()
    {
        if (ShouldShowInterstitial())
        {
            //adMobManager.HideAllBannersNoDelay();
            adMobManager.ShowInterstitialAd();
            PlayerPrefs.SetInt(bannersShownKey, 0);
        }
        else
        {
            //adMobManager.ShowBannerDelayed();
        }
    }

    public void ShowRewardedAd()
    {
        //adMobManager.HideAllBanners();
        adMobManager.ShowRewardedAd();
    }

    public void DestroyBannerAd()
    {
        //adMobManager.DestroyBanners();
        adMobManager.DestroyBanners();
    }

    public void RewardedAdFinished()
    {
        /* Call you Database and UI Manager here. 
         * 
        CoinManager.instance.AddCoins(200);
        MenuUIManager.instance.RewardedAdFinished();
        */
        //adMobManager.ShowBanner();
        EnableTipButton();
    }

    public void TipButton()
    {
        tipbutton.interactable = false;
    }

    public void ShowBanner()
    {
        if (!ShouldShowInterstitial())
            adMobManager.ShowBanner();
    }

    public void ShowDelayedBanner()
    {
        if (!ShouldShowInterstitial())
            adMobManager.ShowBannerDelayed();
    }

    public void HideDelayedBanner()
    {
        adMobManager.HideBannerDelayed();
    }

    public void NoDelayHideBanners()
    {
        adMobManager.HideBanner();
    }


    private bool ShouldShowInterstitial()
    {
        int bannersShown = PlayerPrefs.GetInt(bannersShownKey, 0);
        bannersShown += 1;
        PlayerPrefs.SetInt(bannersShownKey, bannersShown);
        return bannersShown >= bannersShowForInterstitial;
    }

    private void SingletonPattern()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void EnableTipButton()
    {
        tipbutton.interactable = true;
        tipbutton2.interactable = true;
    }

    public void StartTimer() //Call this from OnClick
    {
        tipbutton.interactable = false;
        tipbutton2.interactable = false;
    }
    /*
    private IEnumerator ShowInterstitialDelay(float time)
    {
        yield return new WaitForSeconds(time);
        if (ShouldShowInterstitial())
        {
            adMobManager.HideAllBanners();
            adMobManager.ShowInterstitialAd();
            PlayerPrefs.SetInt(bannersShownKey, 0);
        }
        else
        {
            adMobManager.ShowBanner();
        }
    }
    */
}