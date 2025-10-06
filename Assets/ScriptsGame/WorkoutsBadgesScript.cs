using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class WorkoutsBadgesScript : MonoBehaviour
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

    public Text tenPushups13;
    public GameObject locker13;
    public GameObject image13;

    public Text tenPushups14;
    public GameObject locker14;
    public GameObject image14;

    public Text tenPushups15;
    public GameObject locker15;
    public GameObject image15;

    public Text tenPushups16;
    public GameObject locker16;
    public GameObject image16;

    public Text tenPushups17;
    public GameObject locker17;
    public GameObject image17;

    public Text tenPushups18;
    public GameObject locker18;
    public GameObject image18;

    public Text tenPushups19;
    public GameObject locker19;
    public GameObject image19;

    public Text tenPushups20;
    public GameObject locker20;
    public GameObject image20;

    public void OneWorkoutBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TenPushupsScore", number);
        if (number >= 1)
        {
            tenPushups.text = 1 + "/1";
            locker1.SetActive(false);
            image1.SetActive(true);
        }
        else
        {
            tenPushups.text = PlayerPrefs.GetInt("TenPushupsScore").ToString() + "/1";
            locker1.SetActive(true);
            image1.SetActive(false);
        }
    }

    public void TenWorkoutsBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TenPushupsScore", number);
        if (number >= 10)
        {
            tenPushups2.text = 10 + "/10";
            locker2.SetActive(false);
            image2.SetActive(true);
        }
        else
        {
            tenPushups2.text = PlayerPrefs.GetInt("TenPushupsScore").ToString() + "/10";
            locker2.SetActive(true);
            image2.SetActive(false);
        }
    }

    public void TwentyWorkoutsBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TwentyFivePushupsScore", number);
        if (number >= 20)
        {
            tenPushups3.text = 20 + "/20";
            locker3.SetActive(false);
            image3.SetActive(true);
        }
        else
        {
            tenPushups3.text = PlayerPrefs.GetInt("TwentyFivePushupsScore").ToString() + "/20";
            locker3.SetActive(true);
            image3.SetActive(false);
        }
    }

    public void TwentyFiveWorkoutsBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TwentyFivePushupsScore", number);
        if (number >= 25)
        {
            tenPushups4.text = 25 + "/25";
            locker4.SetActive(false);
            image4.SetActive(true);
        }
        else
        {
            tenPushups4.text = PlayerPrefs.GetInt("TwentyFivePushupsScore").ToString() + "/25";
            locker4.SetActive(true);
            image4.SetActive(false);
        }
    }

    public void FiftyBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("FiftyPushupsScore", number);
        if (number >= 50)
        {
            tenPushups5.text = 50 + "/50";
            locker5.SetActive(false);
            image5.SetActive(true);
        }
        else
        {
            tenPushups5.text = PlayerPrefs.GetInt("FiftyPushupsScore").ToString() + "/50";
            locker5.SetActive(true);
            image5.SetActive(false);
        }
    }

    public void SeventyFiveBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("SeventyFivePushupsScore", number);
        if (number >= 75)
        {
            tenPushups6.text = 75 + "/75";
            locker6.SetActive(false);
            image6.SetActive(true);
        }
        else
        {
            tenPushups6.text = PlayerPrefs.GetInt("SeventyFivePushupsScore").ToString() + "/75";
            locker6.SetActive(true);
            image6.SetActive(false);
        }
    }

    public void EightyBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("SeventyFivePushupsScore", number);
        if (number >= 80)
        {
            tenPushups7.text = 80 + "/80";
            locker7.SetActive(false);
            image7.SetActive(true);
        }
        else
        {
            tenPushups7.text = PlayerPrefs.GetInt("SeventyFivePushupsScore").ToString() + "/80";
            locker7.SetActive(true);
            image7.SetActive(false);
        }
    }

    public void OneHundredBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("OneHundredPushupsScore", number);
        if (number >= 100)
        {
            tenPushups8.text = 100 + "/100";
            locker8.SetActive(false);
            image8.SetActive(true);
        }
        else
        {
            tenPushups8.text = PlayerPrefs.GetInt("OneHundredPushupsScore").ToString() + "/100";
            locker8.SetActive(true);
            image8.SetActive(false);
        }
    }

    public void OneHundredAndTwentyFiveBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("OneHundredAndFiftyPushupsScore", number);
        if (number >= 125)
        {
            tenPushups9.text = 125 + "/125";
            locker9.SetActive(false);
            image9.SetActive(true);
        }
        else
        {
            tenPushups9.text = PlayerPrefs.GetInt("OneHundredAndFiftyPushupsScore").ToString() + "/125";
            locker9.SetActive(true);
            image9.SetActive(false);
        }
    }

    public void OneHundredAndFiftyBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("OneHundredAndFiftyPushupsScore", number);
        if (number >= 150)
        {
            tenPushups10.text = 150 + "/150";
            locker10.SetActive(false);
            image10.SetActive(true);
        }
        else
        {
            tenPushups10.text = PlayerPrefs.GetInt("OneHundredAndFiftyPushupsScore").ToString() + "/150";
            locker10.SetActive(true);
            image10.SetActive(false);
        }
    }

    public void TwoHundredAndFiftyBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TwoHundredAndFiftyPushupsScore", number);
        if (number >= 250)
        {
            tenPushups11.text = 250 + "/250";
            locker11.SetActive(false);
            image11.SetActive(true);
        }
        else
        {
            tenPushups11.text = PlayerPrefs.GetInt("TwoHundredAndFiftyPushupsScore").ToString() + "/250";
            locker11.SetActive(true);
            image11.SetActive(false);
        }
    }

    public void FiveHundredBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("FiveHundredPushupsScore", number);
        if (number >= 500)
        {
            tenPushups12.text = 500 + "/500";
            locker12.SetActive(false);
            image12.SetActive(true);
        }
        else
        {
            tenPushups12.text = PlayerPrefs.GetInt("FiveHundredPushupsScore").ToString() + "/500";
            locker12.SetActive(true);
            image12.SetActive(false);
        }
    }

    public void SevenHundredAndFiftyBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TwoHundredAndFiftyPushupsScore", number);
        if (number >= 750)
        {
            tenPushups13.text = 750 + "/750";
            locker13.SetActive(false);
            image13.SetActive(true);
        }
        else
        {
            tenPushups13.text = PlayerPrefs.GetInt("TwoHundredAndFiftyPushupsScore").ToString() + "/750";
            locker13.SetActive(true);
            image13.SetActive(false);
        }
    }

    public void OneThousandBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("OneThousandPushupsScore", number);
        if (number >= 1000)
        {
            tenPushups14.text = 1000 + "/1K";
            locker14.SetActive(false);
            image14.SetActive(true);
        }
        else
        {
            tenPushups14.text = PlayerPrefs.GetInt("OneThousandPushupsScore").ToString() + "/1K";
            locker14.SetActive(true);
            image14.SetActive(false);
        }
    }

    public void OneThousandSevenHundredAndFiftyBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TwoHundredAndFiftyPushupsScore", number);
        if (number >= 1750)
        {
            tenPushups15.text = 1750 + "/1.75K";
            locker15.SetActive(false);
            image15.SetActive(true);
        }
        else
        {
            tenPushups15.text = PlayerPrefs.GetInt("TwoHundredAndFiftyPushupsScore").ToString() + "/1.75K";
            locker15.SetActive(true);
            image15.SetActive(false);
        }
    }

    public void TwentyFiveHundredBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TwentyFiveHundredPushupsScore", number);
        if (number >= 2500)
        {
            tenPushups16.text = 2500 + "/2.5K";
            locker16.SetActive(false);
            image16.SetActive(true);
        }
        else
        {
            tenPushups16.text = PlayerPrefs.GetInt("TwentyFiveHundredPushupsScore").ToString() + "/2.5K";
            locker16.SetActive(true);
            image16.SetActive(false);
        }
    }

    public void FiveThousandBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("FiveThousandPushupsScore", number);
        if (number >= 5000)
        {
            tenPushups17.text = 5000 + "/5K";
            locker17.SetActive(false);
            image17.SetActive(true);
        }
        else
        {
            tenPushups17.text = PlayerPrefs.GetInt("FiveThousandPushupsScore").ToString() + "/5K";
            locker17.SetActive(true);
            image17.SetActive(false);
        }
    }

    public void SeventyFiveHundredBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("SeventyFiveHundredPushupsScore", number);
        if (number >= 7500)
        {
            tenPushups18.text = 7500 + "/7.5K";
            locker18.SetActive(false);
            image18.SetActive(true);
        }
        else
        {
            tenPushups18.text = PlayerPrefs.GetInt("SeventyFiveHundredPushupsScore").ToString() + "/7.5K";
            locker18.SetActive(true);
            image18.SetActive(false);
        }
    }

    public void EightyFiveHundredBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("SeventyFiveHundredPushupsScore", number);
        if (number >= 8500)
        {
            tenPushups19.text = 8500 + "/8.5K";
            locker19.SetActive(false);
            image19.SetActive(true);
        }
        else
        {
            tenPushups19.text = PlayerPrefs.GetInt("SeventyFiveHundredPushupsScore").ToString() + "/8.5K";
            locker19.SetActive(true);
            image19.SetActive(false);
        }
    }

    public void TenThousandBadges()
    {
        int number = PlayerPrefs.GetInt("TotalWorkouts");
        PlayerPrefs.SetInt("TenThousandPushupsScore", number);
        if (number >= 10000)
        {
            tenPushups20.text = 10000 + "/10K";
            locker20.SetActive(false);
            image20.SetActive(true);
        }
        else
        {
            tenPushups20.text = PlayerPrefs.GetInt("TenThousandPushupsScore").ToString() + "/10K";
            locker20.SetActive(true);
            image20.SetActive(false);
        }
    }

    public void LogOutWorkoutsBadges()
    {
        tenPushups.text = 0 + "/1";
        locker1.SetActive(true);
        image1.SetActive(false);
        tenPushups2.text = 0 + "/10";
        locker2.SetActive(true);
        image2.SetActive(false);
        tenPushups3.text = 0 + "/20";
        locker3.SetActive(true);
        image3.SetActive(false);
        tenPushups4.text = 0 + "/25";
        locker4.SetActive(true);
        image4.SetActive(false);
        tenPushups5.text = 0 + "/50";
        locker5.SetActive(true);
        image5.SetActive(false);
        tenPushups6.text = 0 + "/75";
        locker6.SetActive(true);
        image6.SetActive(false);
        tenPushups7.text = 0 + "/80";
        locker7.SetActive(true);
        image7.SetActive(false);
        tenPushups8.text = 0 + "/100";
        locker8.SetActive(true);
        image8.SetActive(false);
        tenPushups9.text = 0 + "/125";
        locker9.SetActive(true);
        image9.SetActive(false);
        tenPushups10.text = 0 + "/150";
        locker10.SetActive(true);
        image10.SetActive(false);
        tenPushups11.text = 0 + "/250";
        locker11.SetActive(true);
        image11.SetActive(false);
        tenPushups12.text = 0 + "/500";
        locker12.SetActive(true);
        image12.SetActive(false);
        tenPushups13.text = 0 + "/750";
        locker13.SetActive(true);
        image13.SetActive(false);
        tenPushups14.text = 0 + "/1K";
        locker14.SetActive(true);
        image14.SetActive(false);
        tenPushups15.text = 0 + "/1.75K";
        locker15.SetActive(true);
        image15.SetActive(false);
        tenPushups16.text = 0 + "/2.5K";
        locker16.SetActive(true);
        image16.SetActive(false);
        tenPushups17.text = 0 + "/5K";
        locker17.SetActive(true);
        image17.SetActive(false);
        tenPushups18.text = 0 + "/7.5K";
        locker18.SetActive(true);
        image18.SetActive(false);
        tenPushups19.text = 0 + "/8.5K";
        locker19.SetActive(true);
        image19.SetActive(false);
        tenPushups20.text = 0 + "/10K";
        locker20.SetActive(true);
        image20.SetActive(false);
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
            tenPushups13.color = new Color(1f, 1f, 1f, 1f);
            tenPushups14.color = new Color(1f, 1f, 1f, 1f);
            tenPushups15.color = new Color(1f, 1f, 1f, 1f);
            tenPushups16.color = new Color(1f, 1f, 1f, 1f);
            tenPushups17.color = new Color(1f, 1f, 1f, 1f);
            tenPushups18.color = new Color(1f, 1f, 1f, 1f);
            tenPushups19.color = new Color(1f, 1f, 1f, 1f);
            tenPushups20.color = new Color(1f, 1f, 1f, 1f);
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
            tenPushups13.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups14.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups15.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups16.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups17.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups18.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups19.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            tenPushups20.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
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
        tenPushups13.color = new Color(1f, 1f, 1f, 1f);
        tenPushups14.color = new Color(1f, 1f, 1f, 1f);
        tenPushups15.color = new Color(1f, 1f, 1f, 1f);
        tenPushups16.color = new Color(1f, 1f, 1f, 1f);
        tenPushups17.color = new Color(1f, 1f, 1f, 1f);
        tenPushups18.color = new Color(1f, 1f, 1f, 1f);
        tenPushups19.color = new Color(1f, 1f, 1f, 1f);
        tenPushups20.color = new Color(1f, 1f, 1f, 1f);
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
        tenPushups13.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups14.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups15.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups16.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups17.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups18.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups19.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        tenPushups20.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
    }
}
