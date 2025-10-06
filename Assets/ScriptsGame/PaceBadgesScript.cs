using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PaceBadgesScript : MonoBehaviour
{
    public Text tenPushups;
    public GameObject locker1;
    public GameObject image1;

    public Text tenPushups2;
    public GameObject locker2;
    public GameObject image2;

    public Text tenPushups3;
    public GameObject locker3;
    public GameObject image3;

    public Text tenPushups4;
    public GameObject locker4;
    public GameObject image4;

    public Text tenPushups5;
    public GameObject locker5;
    public GameObject image5;

    public Text tenPushups6;
    public GameObject locker6;
    public GameObject image6;

    public Text tenPushups7;
    public GameObject locker7;
    public GameObject image7;

    public Text tenPushups8;
    public GameObject locker8;
    public GameObject image8;

    public Text tenPushups9;
    public GameObject locker9;
    public GameObject image9;

    public Text tenPushups10;
    public GameObject locker10;
    public GameObject image10;

    public Text tenPushups11;
    public GameObject locker11;
    public GameObject image11;

    public Text tenPushups12;
    public GameObject locker12;
    public GameObject image12;

    public void FiveSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 5.00 && number >= 0.4)
        {
            tenPushups.text = 5 + ".00/5.00";
            locker1.SetActive(false);
            image1.SetActive(true);
        }
        else
        {
            tenPushups.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/5.00";
            locker1.SetActive(true);
            image1.SetActive(false);
        }
    }

    public void FourPointFiveSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 4.50 && number >= 0.4)
        {
            tenPushups2.text = 4 + ".50/4.50";
            locker2.SetActive(false);
            image2.SetActive(true);
        }
        else
        {
            tenPushups2.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/4.50";
            locker2.SetActive(true);
            image2.SetActive(false);
        }
    }

    public void FourSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 4.00 && number >= 0.4)
        {
            tenPushups3.text = 4 + ".00/4.00";
            locker3.SetActive(false);
            image3.SetActive(true);
        }
        else
        {
            tenPushups3.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/4.00";
            locker3.SetActive(true);
            image3.SetActive(false);
        }
    }

    public void ThreePointFiveSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 3.50 && number >= 0.4)
        {
            tenPushups4.text = 3 + ".50/3.50";
            locker4.SetActive(false);
            image4.SetActive(true);
        }
        else
        {
            tenPushups4.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/3.50";
            locker4.SetActive(true);
            image4.SetActive(false);
        }
    }

    public void ThreeSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 3.00 && number >= 0.4)
        {
            tenPushups5.text = 3 + ".00/3.00";
            locker5.SetActive(false);
            image5.SetActive(true);
        }
        else
        {
            tenPushups5.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/3.00";
            locker5.SetActive(true);
            image5.SetActive(false);
        }
    }

    public void TwoPointFiveSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 2.50 && number >= 0.4)
        {
            tenPushups6.text = 2 + ".50/2.50";
            locker6.SetActive(false);
            image6.SetActive(true);
        }
        else
        {
            tenPushups6.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/2.50";
            locker6.SetActive(true);
            image6.SetActive(false);
        }
    }

    public void TwoSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 2.00 && number >= 0.4)
        {
            tenPushups7.text = 2 + ".00/2.00";
            locker7.SetActive(false);
            image7.SetActive(true);
        }
        else
        {
            tenPushups7.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/2.00";
            locker7.SetActive(true);
            image7.SetActive(false);
        }
    }

    public void OnePointFiveSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 1.50 && number >= 0.4)
        {
            tenPushups8.text = 1 + ".50/1.50";
            locker8.SetActive(false);
            image8.SetActive(true);
        }
        else
        {
            tenPushups8.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/1.50";
            locker8.SetActive(true);
            image8.SetActive(false);
        }
    }

    public void OneSecondPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 1.00 && number >= 0.4)
        {
            tenPushups9.text = 1 + ".00/1.00";
            locker9.SetActive(false);
            image9.SetActive(true);
        }
        else
        {
            tenPushups9.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/1.00";
            locker9.SetActive(true);
            image9.SetActive(false);
        }
    }

    public void ZeroPointEightSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 0.8 && number >= 0.4)
        {
            tenPushups10.text = 0.8 + "0/0.80";
            locker10.SetActive(false);
            image10.SetActive(true);
        }
        else
        {
            tenPushups10.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/0.80";
            locker10.SetActive(true);
            image10.SetActive(false);
        }
    }

    public void ZeroPointSixSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 0.6 && number >= 0.4)
        {
            tenPushups11.text = 0.6 + "0/0.60";
            locker11.SetActive(false);
            image11.SetActive(true);
        }
        else
        {
            tenPushups11.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/0.60";
            locker11.SetActive(true);
            image11.SetActive(false);
        }
    }

    public void ZeroPointFiftyFourSecondsPace()
    {
        float number = PlayerPrefs.GetFloat("TotalAvgSum");
        PlayerPrefs.SetFloat("TenPushupsScore", number);
        if (number <= 0.54 && number >= 0.4)
        {
            tenPushups12.text = 0.54 + "/0.54";
            locker12.SetActive(false);
            image12.SetActive(true);
        }
        else
        {
            tenPushups12.text = PlayerPrefs.GetFloat("TenPushupsScore").ToString("F2") + "/0.54";
            locker12.SetActive(true);
            image12.SetActive(false);
        }
    }

    public void LogOutPaceBadges()
    {
        tenPushups.text = 0 + "/5.00";
        locker1.SetActive(true);
        image1.SetActive(false);
        tenPushups2.text = 0 + "/4.50";
        locker2.SetActive(true);
        image2.SetActive(false);
        tenPushups3.text = 0 + "/4.00";
        locker3.SetActive(true);
        image3.SetActive(false);
        tenPushups4.text = 0 + "/3.50";
        locker4.SetActive(true);
        image4.SetActive(false);
        tenPushups5.text = 0 + "/3.00";
        locker5.SetActive(true);
        image5.SetActive(false);
        tenPushups6.text = 0 + "/2.50";
        locker6.SetActive(true);
        image6.SetActive(false);
        tenPushups7.text = 0 + "/2.00";
        locker7.SetActive(true);
        image7.SetActive(false);
        tenPushups8.text = 0 + "/1.50";
        locker8.SetActive(true);
        image8.SetActive(false);
        tenPushups9.text = 0 + "/1.00";
        locker9.SetActive(true);
        image9.SetActive(false);
        tenPushups10.text = 0 + "/0.80";
        locker10.SetActive(true);
        image10.SetActive(false);
        tenPushups11.text = 0 + "/0.60";
        locker11.SetActive(true);
        image11.SetActive(false);
        tenPushups12.text = 0 + "/0.54";
        locker12.SetActive(true);
        image12.SetActive(false);
    }

    void Start()
    {
        if (PlayerPrefs.GetInt("Theme") == 1)
        {
            tenPushups.color = new Color(1f, 1f, 1f, 1f);
            tenPushups2.color = new Color(1f, 1f, 1f, 1f);
            tenPushups3.color = new Color(1f, 1f, 1f, 1f);
            tenPushups4.color = new Color(1f, 1f, 1f, 1f);
            tenPushups5.color = new Color(1f, 1f, 1f, 1f);
            tenPushups6.color = new Color(1f, 1f, 1f, 1f);
            tenPushups7.color = new Color(1f, 1f, 1f, 1f);
            tenPushups8.color = new Color(1f, 1f, 1f, 1f);
            tenPushups9.color = new Color(1f, 1f, 1f, 1f);
            tenPushups10.color = new Color(1f, 1f, 1f, 1f);
            tenPushups11.color = new Color(1f, 1f, 1f, 1f);
            tenPushups12.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Theme") == 0)
        {
            tenPushups.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups2.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups3.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups4.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups5.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups6.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups7.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups8.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups9.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups10.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups11.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups12.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        }
    }

    public void PushupTextColorLightMode()
    {
        tenPushups.color = new Color(1f, 1f, 1f, 1f);
        tenPushups2.color = new Color(1f, 1f, 1f, 1f);
        tenPushups3.color = new Color(1f, 1f, 1f, 1f);
        tenPushups4.color = new Color(1f, 1f, 1f, 1f);
        tenPushups5.color = new Color(1f, 1f, 1f, 1f);
        tenPushups6.color = new Color(1f, 1f, 1f, 1f);
        tenPushups7.color = new Color(1f, 1f, 1f, 1f);
        tenPushups8.color = new Color(1f, 1f, 1f, 1f);
        tenPushups9.color = new Color(1f, 1f, 1f, 1f);
        tenPushups10.color = new Color(1f, 1f, 1f, 1f);
        tenPushups11.color = new Color(1f, 1f, 1f, 1f);
        tenPushups12.color = new Color(1f, 1f, 1f, 1f);
    }

    public void PushupTextColorDarkMode()
    {
        tenPushups.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups2.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups3.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups4.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups5.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups6.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups7.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups8.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups9.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups10.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups11.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups12.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
    }
}
