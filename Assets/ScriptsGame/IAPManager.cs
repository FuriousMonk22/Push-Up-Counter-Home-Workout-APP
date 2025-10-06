using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class IAPManager : MonoBehaviour
{
    public GameObject AdsManager;
    public Button tipButton;
    public Button tipButton2;
    public Button proButton;
    public Button proButton2;
    private string removeAds = "com.FuriousPandaGames.PushUpCounter.removeAds";

    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id == removeAds)
        {
            tipButton.interactable = false;
            tipButton2.interactable = false;
            proButton.interactable = false;
            proButton2.interactable = false;
            PlayerPrefs.SetInt("VerifyPro", 1);
            Destroy(AdsManager);
            Debug.Log("All ads removed!");
        }
    }
    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(product.definition.id + " failed because" + failureReason);
    }
}
