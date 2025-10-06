using UnityEngine;
using System;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using System.Globalization;

//-4.45 si -2.1 la bile

public class MainScript : MonoBehaviour
{
    //public int oc = 1;
    public int rememberScore;
    public int rememberWorkouts;
    public int workouts;
    public int score;
    public Text scoreText;
    public float cooldownTime;
    private bool inCooldown;
    public int ok = 0;
    public bool test_senzor = true;
    public int stop = 1;
    public int remember;
    //public int advices = 0;
    public int music = 1;
    public int stope;
    public int musicc = 1;
    public float pushupTimeMax = 0;
    public float pushreduce1;

    public GameObject managerAds;
    public AdsManager managerads;
    public Text PushupsText;
    public Text PaceText;
    public Text WorkoutsText;
    public TMP_InputField workoutsInput;
    public TMP_InputField pushupInput;
    public TMP_InputField pushtimeavgInput;
    public Text pushtimeText;
    public Text pushtimeavgText;
    public Text pushtimeText1;
    public Text pushtimeavgText1;
    public Text muziciText;

    public GameObject ChristianText;
    public GameObject ChristianButton;
    public GameObject ChristianButton1;
    public GameObject preessToPlayText;
    public GameObject preessToPlayText1;
    public GameObject Music1;
    public GameObject Music2;
    public GameObject Music3;
    public GameObject Music1Button;
    public GameObject Music2Button;
    public GameObject Music3Button;
    public GameObject MusicButtonYes;
    public GameObject MusicButtonNo;
    public GameObject paceIndicator;
    public GameObject paceIndicatorButtonYes;
    public GameObject paceIndicatorButtonNo;

    public GameObject darkReturnMenuText;
    public GameObject lightReturnMenuText;
    public SpriteRenderer darkModeSquareReturnMenu;
    public Image darkModeSquareReset;
    public Text resetCanvasText;
    public Text paceIndicatorTitle;
    public GameObject playButtonDarkMode;
    public GameObject playButtonLightMode;
    public Text musicTryASongText;
    public GameObject resetButtonDarkMode;
    public GameObject returnMenuButtonDarkMode;
    public GameObject backButtonDarkMode;
    public GameObject resetButtonLightMode;
    public GameObject returnMenuButtonLightMode;
    public GameObject backButtonLightMode;
    public GameObject backgroundPanelDarkMode;
    public GameObject backgroundPanelLightMode;
    public GameObject menuIntern;
    public GameObject butoaneJoc;
    public GameObject pauseButton1;
    public GameObject pauseButton2;
    public GameObject texteTimp;
    public GameObject scoreText1;
    public Text scoreText2;

    private float push_starttime;
    private float pushreduce;
    private float pushtimesum;
    private float pushtimeavg;

    public GameObject bilaGameObjectToMove1;
    public GameObject bilaGameObjectToMove2;

    public Text field;
    public float currentDisplayScore = 0;

    //DELAY A BUTTON
    //public Button TheButton;
    //public float ButtonReactivateDelay = 1f;

    //// Assign this as your OnClick listener from the inspector
    //public void WhenClicked()
    //{
    //    TheButton.interactable = false;
    //    StartCoroutine(EnableButtonAfterDelay(TheButton, ButtonReactivateDelay));

    //    // Do whatever else your button is supposed to do.
    //}

    //IEnumerator EnableButtonAfterDelay(Button button, float seconds)
    //{
    //    yield return new WaitForSeconds(seconds);
    //    button.interactable = true;
    //}

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Musicc", musicc);
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            Time.timeScale = 0;
            menuIntern.SetActive(true);
            butoaneJoc.SetActive(false);
            pauseButton2.SetActive(true);
            pauseButton1.SetActive(false);
            texteTimp.SetActive(false);
            scoreText1.SetActive(false);
        }
    }

    public void Start()
    {
        if (PlayerPrefs.GetInt("VerifyPro") == 1)
        {
            managerads.HideBanners();
            Destroy(managerAds);
        }

        if (PlayerPrefs.GetInt("MusicCheck") == 1)
        {
            MusicButtonYes.SetActive(true);
            MusicButtonNo.SetActive(false);
            //mai merge text la muzici
            if (PlayerPrefs.GetInt("Music1") == 1)
            {
                Music1.SetActive(true);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(true);
                Music2Button.SetActive(false);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Deal - AShamaluevMusic";
                muziciText.color = Color.magenta;
            }

            if (PlayerPrefs.GetInt("Music2") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(true);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(true);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Epic - Bensound";
                muziciText.color = Color.red;
            }

            if (PlayerPrefs.GetInt("Music3") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(true);
                Music1Button.SetActive(false);
                Music2Button.SetActive(false);
                Music3Button.SetActive(true);
                muziciText.text = "Now playing: Hipjazz - Bensound";
                muziciText.color = Color.blue;
            }
        }
        else
        {
            MusicButtonYes.SetActive(false);
            MusicButtonNo.SetActive(true);
            if (PlayerPrefs.GetInt("Music1") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(true);
                Music2Button.SetActive(false);
                Music3Button.SetActive(false);
                muziciText.text = "Nothing playing right now!";
                muziciText.color = Color.black;
            }

            if (PlayerPrefs.GetInt("Music2") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(true);
                Music3Button.SetActive(false);
                muziciText.text = "Nothing playing right now!";
                muziciText.color = Color.black;
            }

            if (PlayerPrefs.GetInt("Music3") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(false);
                Music3Button.SetActive(true);
                muziciText.text = "Nothing playing right now!";
                muziciText.color = Color.black;
            }
        }

        if(PlayerPrefs.GetInt("Indicator") == 1)
        {
            paceIndicatorButtonYes.SetActive(true);
            paceIndicatorButtonNo.SetActive(false);
            paceIndicator.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Indicator") == 0)
        {
            paceIndicatorButtonYes.SetActive(false);
            paceIndicatorButtonNo.SetActive(true);
            paceIndicator.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Christian") == 0)
        {
            ChristianButton.SetActive(true);
            ChristianButton1.SetActive(false);
            ChristianText.SetActive(false);
            preessToPlayText.SetActive(true);
            preessToPlayText1.SetActive(true);
        }
        else
        {
            ChristianButton.SetActive(false);
            ChristianButton1.SetActive(true);
            ChristianText.SetActive(true);
            preessToPlayText.SetActive(false);
            preessToPlayText1.SetActive(false);
        }
        ///////////////////////////////
        if(PlayerPrefs.GetInt("Theme") == 0)
        {
            lightReturnMenuText.SetActive(false);
            darkReturnMenuText.SetActive(true);
            darkModeSquareReturnMenu.color = new Color(0.2196079f, 0.2196079f, 0.2196079f, 1f);
            darkModeSquareReset.color = new Color(0.2196079f, 0.2196079f, 0.2196079f, 1f);
            resetCanvasText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            pushtimeText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            pushtimeText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            pushtimeavgText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            pushtimeavgText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            paceIndicatorTitle.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            field.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            playButtonLightMode.SetActive(false);
            playButtonDarkMode.SetActive(true);
            musicTryASongText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            backButtonDarkMode.SetActive(true);
            returnMenuButtonDarkMode.SetActive(true);
            resetButtonDarkMode.SetActive(true);
            backButtonLightMode.SetActive(false);
            returnMenuButtonLightMode.SetActive(false);
            resetButtonLightMode.SetActive(false);
            backgroundPanelLightMode.SetActive(false);
            backgroundPanelDarkMode.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Theme") == 1)
        {
            lightReturnMenuText.SetActive(true);
            darkReturnMenuText.SetActive(false);
            darkModeSquareReturnMenu.color = new Color(0.3019608f, 1f, 0f, 1f);
            darkModeSquareReset.color = new Color(0.3019608f, 1f, 0f, 1f);
            resetCanvasText.color = new Color(0f, 0f, 0f, 1f);
            pushtimeText.color = new Color(0f, 0f, 0f, 1f);
            pushtimeText1.color = new Color(0f, 0f, 0f, 1f);
            pushtimeavgText.color = new Color(0f, 0f, 0f, 1f);
            pushtimeavgText1.color = new Color(0f, 0f, 0f, 1f);
            paceIndicatorTitle.color = new Color(0f, 0f, 0f, 1f);
            field.color = new Color(0f, 0f, 0f, 1f);
            playButtonDarkMode.SetActive(false);
            playButtonLightMode.SetActive(true);
            musicTryASongText.color = new Color(0f, 0f, 0f, 1f);
            backButtonDarkMode.SetActive(false);
            returnMenuButtonDarkMode.SetActive(false);
            resetButtonDarkMode.SetActive(false);
            backButtonLightMode.SetActive(true);
            returnMenuButtonLightMode.SetActive(true);
            resetButtonLightMode.SetActive(true);
            backgroundPanelDarkMode.SetActive(false);
            backgroundPanelLightMode.SetActive(true);
        }

        
    }

    public void AddOne()
    {
        score++;
        //oc = 1;
    }

    public void SubstractOne()
    {
        if (score > 0)
            score--;
        //if (oc == 0)
        //{
        //    pushtimesum -= pushreduce;
        //    pushtimeavg = pushtimesum / (score - 1);
        //    oc = 1;
        //}
    }

    public void PaceIndicator1()
    {
        PlayerPrefs.SetInt("Indicator", 0);
    }

    public void PaceIndicator2()
    {
        PlayerPrefs.SetInt("Indicator", 1);
    }

    public void MusicButton1()
    {//mai merge text la muzici
        if (PlayerPrefs.GetInt("MusicCheck") == 1)
        {
            if (Music2.activeSelf == true)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(true);
                Music1Button.SetActive(false);
                Music2Button.SetActive(false);
                Music3Button.SetActive(true);
                muziciText.text = "Now playing: Hipjazz - Bensound";
                muziciText.color = Color.blue;
            }

            if (Music3.activeSelf == true)
            {
                Music1.SetActive(true);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(true);
                Music2Button.SetActive(false);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Deal - AShamaluevMusic";
                muziciText.color = Color.magenta;
            }

            if (Music1.activeSelf == true)
            {
                Music1.SetActive(false);
                Music2.SetActive(true);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(true);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Epic - Bensound";
                muziciText.color = Color.red;
            }
        }
    }
    //aicea e timpu pe bile********************************************************
    public void MoveToPosition1()
    {
        LeanTween.moveY(bilaGameObjectToMove1, -4.42f, 2);
        LeanTween.moveY(bilaGameObjectToMove2, -4.42f, 2);
    }

    public void MusicButton2()
    {//mai merge text la muzici
        if (PlayerPrefs.GetInt("MusicCheck") == 1)
        {
            if (Music3.activeSelf == true)
            {
                Music1.SetActive(true);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(true);
                Music2Button.SetActive(false);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Deal - AShamaluevMusic";
                muziciText.color = Color.magenta;
            }

            if (Music1.activeSelf == true)
            {
                Music1.SetActive(false);
                Music2.SetActive(true);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(true);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Epic - Bensound";
                muziciText.color = Color.red;
            }

            if (Music2.activeSelf == true)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(true);
                Music1Button.SetActive(false);
                Music2Button.SetActive(false);
                Music3Button.SetActive(true);
                muziciText.text = "Now playing: Hipjazz - Bensound";
                muziciText.color = Color.blue;
            }
        }
    }

    public void MusicButton3()
    {//mai merge text la muzici
        if (PlayerPrefs.GetInt("MusicCheck") == 1)
        {
            if (Music1.activeSelf == true)
            {
                Music1.SetActive(false);
                Music2.SetActive(true);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(true);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Epic - Bensound";
                muziciText.color = Color.red;
            }

            if (Music2.activeSelf == true)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(true);
                Music1Button.SetActive(false);
                Music2Button.SetActive(false);
                Music3Button.SetActive(true);
                muziciText.text = "Now playing: Hipjazz - Bensound";
                muziciText.color = Color.blue;
            }

            if (Music3.activeSelf == true)
            {
                Music1.SetActive(true);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(true);
                Music2Button.SetActive(false);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Deal - AShamaluevMusic";
                muziciText.color = Color.magenta;
            }
        }
    }


    public void NoPushup()
    {
        if (score == 0)
            ReturnMenu();
    }

    public void ChristianAdvice()
    {
        int advice = 1;
        PlayerPrefs.SetInt("Christian", advice);
    }

    public void ChristianAdvice1()
    {
        int advice = 0;
        PlayerPrefs.SetInt("Christian", advice);
    }

    public void MusicYes()
    {
        music = 0;
        PlayerPrefs.SetInt("MusicCheck", music);
    }

    public void MusicNo()
    {
        music = 1;
        PlayerPrefs.SetInt("MusicCheck", music);
    }

    public void ResetScore()
    {
        var day1 = System.DateTime.Today;

        if (PlayerPrefs.GetInt("Christian") == 0)
        {
            ChristianButton.SetActive(true);
            ChristianButton1.SetActive(false);
            ChristianText.SetActive(false);
            preessToPlayText.SetActive(true);
            preessToPlayText1.SetActive(true);
        }
        rememberScore = score;
        Time.timeScale = 1;
        score = 0;
        pushtimesum = 0;
        pushtimeavg = 0;
        pushreduce = 0;
        pushreduce1 = 0;
        push_starttime = 0;
        int resetpushups = PlayerPrefs.GetInt("TotalPushups");

        if (day1.DayOfWeek == DayOfWeek.Monday)
        {
            int resetpushups1 = PlayerPrefs.GetInt("TotalPushups1");
            resetpushups1 -= rememberScore;
            PlayerPrefs.SetInt("TotalPushups1", resetpushups1);
        }

        if (day1.DayOfWeek == DayOfWeek.Tuesday)
        {
            int resetpushups1 = PlayerPrefs.GetInt("TotalPushups2");
            resetpushups1 -= rememberScore;
            PlayerPrefs.SetInt("TotalPushups2", resetpushups1);
        }

        if (day1.DayOfWeek == DayOfWeek.Wednesday)
        {
            int resetpushups1 = PlayerPrefs.GetInt("TotalPushups3");
            resetpushups1 -= rememberScore;
            PlayerPrefs.SetInt("TotalPushups3", resetpushups1);
        }

        if (day1.DayOfWeek == DayOfWeek.Thursday)
        {
            int resetpushups1 = PlayerPrefs.GetInt("TotalPushups4");
            resetpushups1 -= rememberScore;
            PlayerPrefs.SetInt("TotalPushups4", resetpushups1);
        }

        if (day1.DayOfWeek == DayOfWeek.Friday)
        {
            int resetpushups1 = PlayerPrefs.GetInt("TotalPushups5");
            resetpushups1 -= rememberScore;
            PlayerPrefs.SetInt("TotalPushups5", resetpushups1);
        }

        if (day1.DayOfWeek == DayOfWeek.Saturday)
        {
            int resetpushups1 = PlayerPrefs.GetInt("TotalPushups6");
            resetpushups1 -= rememberScore;
            PlayerPrefs.SetInt("TotalPushups6", resetpushups1);
        }

        if (day1.DayOfWeek == DayOfWeek.Sunday)
        {
            int resetpushups1 = PlayerPrefs.GetInt("TotalPushups7");
            resetpushups1 -= rememberScore;
            PlayerPrefs.SetInt("TotalPushups7", resetpushups1);
        }

        resetpushups -= rememberScore;
        remember = rememberScore;
        PlayerPrefs.SetInt("TotalPushups", resetpushups);
        
        if (ok == 1)
        {
            if (day1.DayOfWeek == DayOfWeek.Monday)
            {
                int savedworkout3 = PlayerPrefs.GetInt("TotalWorkouts1");
                savedworkout3 -= 1;
                PlayerPrefs.SetInt("TotalWorkouts1", savedworkout3);
            }

            if (day1.DayOfWeek == DayOfWeek.Tuesday)
            {
                int savedworkout3 = PlayerPrefs.GetInt("TotalWorkouts2");
                savedworkout3 -= 1;
                PlayerPrefs.SetInt("TotalWorkouts2", savedworkout3);
            }

            if (day1.DayOfWeek == DayOfWeek.Wednesday)
            {
                int savedworkout3 = PlayerPrefs.GetInt("TotalWorkouts3");
                savedworkout3 -= 1;
                PlayerPrefs.SetInt("TotalWorkouts3", savedworkout3);
            }

            if (day1.DayOfWeek == DayOfWeek.Thursday)
            {
                int savedworkout3 = PlayerPrefs.GetInt("TotalWorkouts4");
                savedworkout3 -= 1;
                PlayerPrefs.SetInt("TotalWorkouts4", savedworkout3);
            }

            if (day1.DayOfWeek == DayOfWeek.Friday)
            {
                int savedworkout3 = PlayerPrefs.GetInt("TotalWorkouts5");
                savedworkout3 -= 1;
                PlayerPrefs.SetInt("TotalWorkouts5", savedworkout3);
            }

            if (day1.DayOfWeek == DayOfWeek.Saturday)
            {
                int savedworkout3 = PlayerPrefs.GetInt("TotalWorkouts6");
                savedworkout3 -= 1;
                PlayerPrefs.SetInt("TotalWorkouts6", savedworkout3);
            }

            if (day1.DayOfWeek == DayOfWeek.Sunday)
            {
                int savedworkout3 = PlayerPrefs.GetInt("TotalWorkouts7");
                savedworkout3 -= 1;
                PlayerPrefs.SetInt("TotalWorkouts7", savedworkout3);
            }

            int savedWorkout2 = PlayerPrefs.GetInt("TotalWorkouts");
            savedWorkout2 -= 1;
            PlayerPrefs.SetInt("TotalWorkouts", savedWorkout2);

            ok = 0;
        }
        stop = 0;
    }

    private void Awake()
    {
        musicc = PlayerPrefs.GetInt("Musicc");
        PlayerPrefs.SetInt("Music1", musicc);

        music = PlayerPrefs.GetInt("MusicCheck");
        PlayerPrefs.SetInt("MusicCheck", music);
        Application.targetFrameRate = -1;
        //if (PlayerPrefs.GetInt("Christian") == 0)
        //    PlayerPrefs.SetInt("Effect", advices);
    }

    public void AddScore()
    {
        if (!inCooldown)
        {
            score++;
            //oc = 0;
            TotalPushupsUpdater();
            //LeanTween.pause(linieToMove);
            LeanTween.cancel(bilaGameObjectToMove1);
            LeanTween.cancel(bilaGameObjectToMove2);
            LeanTween.moveY(bilaGameObjectToMove1, -2.07f, 0.01f).setOnComplete(MoveToPosition1);
            LeanTween.moveY(bilaGameObjectToMove2, -2.07f, 0.01f).setOnComplete(MoveToPosition1);

            if (score > 1)
            {
                pushtimesum += pushreduce;
                pushtimeavg = pushtimesum / (score - 1);
            }
            push_starttime = Time.time;
            StartCoroutine(Cooldown());
        }
    }

    void TotalPushupsUpdater()
    {
        //int HourNow = System.DateTime.Now.Hour;
        //int MinutesNow = System.DateTime.Now.Minute;
        //int SecondsNow = System.DateTime.Now.Second;

        int savedPushup = PlayerPrefs.GetInt("TotalPushups");
        savedPushup += 1;
        PlayerPrefs.SetInt("TotalPushups", savedPushup);

        var day1 = System.DateTime.Today;
        if (day1.DayOfWeek == DayOfWeek.Monday)
        {
            int savedPushup1 = PlayerPrefs.GetInt("TotalPushups1");
            savedPushup1 += 1;
            PlayerPrefs.SetInt("TotalPushups1", savedPushup1);
        }

        if (day1.DayOfWeek == DayOfWeek.Tuesday)
        {
            int savedPushup2 = PlayerPrefs.GetInt("TotalPushups2");
            savedPushup2 += 1;
            PlayerPrefs.SetInt("TotalPushups2", savedPushup2);
        }

        if (day1.DayOfWeek == DayOfWeek.Wednesday)
        {
            int savedPushup3 = PlayerPrefs.GetInt("TotalPushups3");
            savedPushup3 += 1;
            PlayerPrefs.SetInt("TotalPushups3", savedPushup3);
        }

        if (day1.DayOfWeek == DayOfWeek.Thursday)
        {
            int savedPushup3 = PlayerPrefs.GetInt("TotalPushups4");
            savedPushup3 += 1;
            PlayerPrefs.SetInt("TotalPushups4", savedPushup3);
        }

        if (day1.DayOfWeek == DayOfWeek.Friday)
        {
            int savedPushup3 = PlayerPrefs.GetInt("TotalPushups5");
            savedPushup3 += 1;
            PlayerPrefs.SetInt("TotalPushups5", savedPushup3);
        }

        if (day1.DayOfWeek == DayOfWeek.Saturday)
        {
            int savedPushup3 = PlayerPrefs.GetInt("TotalPushups6");
            savedPushup3 += 1;
            PlayerPrefs.SetInt("TotalPushups6", savedPushup3);
        }

        if (day1.DayOfWeek == DayOfWeek.Sunday)
        {
            int savedPushup3 = PlayerPrefs.GetInt("TotalPushups7");
            savedPushup3 += 1;
            PlayerPrefs.SetInt("TotalPushups7", savedPushup3);
        }

    }

    void Update()
    {
        if (Music1.activeSelf == true)
        {
            int ok1 = 1;
            PlayerPrefs.SetInt("Music1", ok1);
            int ok2 = 0;
            PlayerPrefs.SetInt("Music2", ok2);
            int ok3 = 0;
            PlayerPrefs.SetInt("Music3", ok3);
            musicc = 1;
        }

        if (Music2.activeSelf == true)
        {
            int ok1 = 0;
            PlayerPrefs.SetInt("Music1", ok1);
            int ok2 = 1;
            PlayerPrefs.SetInt("Music2", ok2);
            int ok3 = 0;
            PlayerPrefs.SetInt("Music3", ok3);
            musicc = 0;
        }

        if (Music3.activeSelf == true)
        {
            int ok1 = 0;
            PlayerPrefs.SetInt("Music1", ok1);
            int ok2 = 0;
            PlayerPrefs.SetInt("Music2", ok2);
            int ok3 = 1;
            PlayerPrefs.SetInt("Music3", ok3);
            musicc = 0;
        }

        if (PlayerPrefs.GetInt("MusicCheck") == 0)
        {
            if (PlayerPrefs.GetInt("Music1") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(true);
                Music2Button.SetActive(false);
                Music3Button.SetActive(false);
                muziciText.text = "Nothing playing right now!";
                muziciText.color = Color.black;
                musicc = 0;
            }

            if (PlayerPrefs.GetInt("Music2") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(true);
                Music3Button.SetActive(false);
                muziciText.text = "Nothing playing right now!";
                muziciText.color = Color.black;
            }

            if (PlayerPrefs.GetInt("Music3") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(false);
                Music3Button.SetActive(true);
                muziciText.text = "Nothing playing right now!";
                muziciText.color = Color.black;
            }
            stope = 1;
        }

        if(PlayerPrefs.GetInt("MusicCheck") == 1 && stope == 1)
        {
            if (PlayerPrefs.GetInt("Music1") == 1)
            {
                Music1.SetActive(true);
                Music2.SetActive(false);
                Music3.SetActive(false);
                Music1Button.SetActive(true);
                Music2Button.SetActive(false);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Deal - AShamaluevMusic";
                muziciText.color = Color.magenta;
                musicc = 1;
            }

            if (PlayerPrefs.GetInt("Music2") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(true);
                Music3.SetActive(false);
                Music1Button.SetActive(false);
                Music2Button.SetActive(true);
                Music3Button.SetActive(false);
                muziciText.text = "Now playing: Epic - Bensound";
                muziciText.color = Color.red;
                musicc = 0;
            }

            if (PlayerPrefs.GetInt("Music3") == 1)
            {
                Music1.SetActive(false);
                Music2.SetActive(false);
                Music3.SetActive(true);
                Music1Button.SetActive(false);
                Music2Button.SetActive(false);
                Music3Button.SetActive(true);
                muziciText.text = "Now playing: Hipjazz - Bensound";
                muziciText.color = Color.blue;
                musicc = 0;
            }
            stope = 0;
        }

        if(pushreduce1 > pushupTimeMax && PlayerPrefs.GetInt("Indicator") == 1)
        {
            pushupTimeMax = pushreduce1;
            field.text = pushupTimeMax.ToString("F2") + " sec.";
        }

        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
        pushreduce = Time.time - push_starttime;
        if (score > 0)
            pushreduce1 = Time.time - push_starttime;
        if (score >= 1)
        {
            pushtimeText.text = "Time/Pushup: " + pushreduce.ToString("F2") + " seconds";
            pushtimeText1.text = "Time/Pushup: " + pushreduce.ToString("F2") + " seconds";
        }
        if (score < 1)
        {
            pushtimeText.text = "Time/Pushup";
            pushtimeText1.text = "Time/Pushup";
        }
        if (score <= 1)
        {
            pushtimeavgText.text = "Average Time/Pushup";
            pushtimeavgText1.text = "Average Time/Pushup";
        }
        if (score >= 2)
        {
            pushtimeavgText.text = "Average Time/Pushup: " + pushtimeavg.ToString("F2") + " sec.";
            pushtimeavgText1.text = "Average Time/Pushup: " + pushtimeavg.ToString("F2") + " sec.";
        }

        InputSystem.EnableDevice(ProximitySensor.current);
        if (ProximitySensor.current.distance.ReadValue() == 0 && test_senzor == false)
        { 
            AddScore();
            test_senzor = true;
        }

        if (ProximitySensor.current.distance.ReadValue() == 5)
        {
            //AddScore();
            test_senzor = false;
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
        //score = 0;
    }

    public void ReturnMenu()
    {
        rememberScore = score;
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 0;
        if (Music1.activeSelf == true)
        {
            int ok1 = 1;
            PlayerPrefs.SetInt("Music1", ok1);
            int ok2 = 0;
            PlayerPrefs.SetInt("Music2", ok2);
            int ok3 = 0;
            PlayerPrefs.SetInt("Music3", ok3);
            musicc = 1;
        }

        if (Music2.activeSelf == true)
        {
            int ok1 = 0;
            PlayerPrefs.SetInt("Music1", ok1);
            int ok2 = 1;
            PlayerPrefs.SetInt("Music2", ok2);
            int ok3 = 0;
            PlayerPrefs.SetInt("Music3", ok3);
            musicc = 0;
        }

        if (Music3.activeSelf == true)
        {
            int ok1 = 0;
            PlayerPrefs.SetInt("Music1", ok1);
            int ok2 = 0;
            PlayerPrefs.SetInt("Music2", ok2);
            int ok3 = 1;
            PlayerPrefs.SetInt("Music3", ok3);
            musicc = 0;
        }
        //if (stop == 1)
        //{
        //    int resetpushups1 = PlayerPrefs.GetInt("TotalPushups");
        //    resetpushups1 -= (rememberScore - remember);
        //    PlayerPrefs.SetInt("TotalPushups", resetpushups1);
        //}
    }

    public void SaveScore()
    {
        if (score > 0 && ok == 0)
        {
            var day1 = System.DateTime.Today;
            if (day1.DayOfWeek == DayOfWeek.Sunday)
            {
                int savedWorkout1 = PlayerPrefs.GetInt("TotalWorkouts7");
                savedWorkout1 += 1;
                PlayerPrefs.SetInt("TotalWorkouts7", savedWorkout1);

                int sunday = PlayerPrefs.GetInt("TotalWorkouts7");
                PlayerPrefs.SetInt("TotalWorkoutsSun", sunday);
            }

            if (day1.DayOfWeek == DayOfWeek.Saturday)
            {
                int savedWorkout1 = PlayerPrefs.GetInt("TotalWorkouts6");
                savedWorkout1 += 1;
                PlayerPrefs.SetInt("TotalWorkouts6", savedWorkout1);

                int saturday = PlayerPrefs.GetInt("TotalWorkouts6");
                PlayerPrefs.SetInt("TotalWorkoutsSat", saturday);
            }

            if (day1.DayOfWeek == DayOfWeek.Friday)
            {
                int savedWorkout1 = PlayerPrefs.GetInt("TotalWorkouts5");
                savedWorkout1 += 1;
                PlayerPrefs.SetInt("TotalWorkouts5", savedWorkout1);

                int friday = PlayerPrefs.GetInt("TotalWorkouts5");
                PlayerPrefs.SetInt("TotalWorkoutsFri", friday);
            }

            if (day1.DayOfWeek == DayOfWeek.Thursday)
            {
                int savedWorkout1 = PlayerPrefs.GetInt("TotalWorkouts4");
                savedWorkout1 += 1;
                PlayerPrefs.SetInt("TotalWorkouts4", savedWorkout1);

                int thursday = PlayerPrefs.GetInt("TotalWorkouts4");
                PlayerPrefs.SetInt("TotalWorkoutsThu", thursday);
            }

            if (day1.DayOfWeek == DayOfWeek.Wednesday)
            {
                int savedWorkout1 = PlayerPrefs.GetInt("TotalWorkouts3");
                savedWorkout1 += 1;
                PlayerPrefs.SetInt("TotalWorkouts3", savedWorkout1);

                int wednesday = PlayerPrefs.GetInt("TotalWorkouts3");
                PlayerPrefs.SetInt("TotalWorkoutsWed", wednesday);
            }

            if (day1.DayOfWeek == DayOfWeek.Tuesday)
            {
                int savedWorkout1 = PlayerPrefs.GetInt("TotalWorkouts2");
                savedWorkout1 += 1;
                PlayerPrefs.SetInt("TotalWorkouts2", savedWorkout1);

                int tuesday = PlayerPrefs.GetInt("TotalWorkouts2");
                PlayerPrefs.SetInt("TotalWorkoutsTue", tuesday);
            }

            if (day1.DayOfWeek == DayOfWeek.Monday)
            {
                int savedWorkout1 = PlayerPrefs.GetInt("TotalWorkouts1");
                savedWorkout1 += 1;
                PlayerPrefs.SetInt("TotalWorkouts1", savedWorkout1);

                int monday = PlayerPrefs.GetInt("TotalWorkouts1");
                PlayerPrefs.SetInt("TotalWorkoutsMon", monday);
            }

            int savedWorkout = PlayerPrefs.GetInt("TotalWorkouts");
            savedWorkout += 1;
            PlayerPrefs.SetInt("TotalWorkouts", savedWorkout);

            //int HourNow = System.DateTime.Now.Hour;
            //int MinutesNow = System.DateTime.Now.Minute;
            //int SecondsNow = System.DateTime.Now.Second;

            ok = 1;
        }
        if (score >= 2)
        {
            //int HourNow = System.DateTime.Now.Hour;
            //int MinutesNow = System.DateTime.Now.Minute;
            //int SecondsNow = System.DateTime.Now.Second;

            var day1 = System.DateTime.Today;

            int savedAvgPaceWorkouts = PlayerPrefs.GetInt("TotalAvgPaceWorkouts");
            savedAvgPaceWorkouts += 1;
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts", savedAvgPaceWorkouts);

            //daily journal
            if (day1.DayOfWeek == DayOfWeek.Monday)
            {
                int savedAvgPaceWorkouts1 = PlayerPrefs.GetInt("TotalAvgPaceWorkouts1");
                savedAvgPaceWorkouts1 += 1;
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", savedAvgPaceWorkouts1);

                float SavedAvgSum1 = PlayerPrefs.GetFloat("AveragesSum1");
                SavedAvgSum1 += pushtimeavg;
                PlayerPrefs.SetFloat("AveragesSum1", SavedAvgSum1);

                float SavedAvgTotal1 = SavedAvgSum1 / savedAvgPaceWorkouts1;
                PlayerPrefs.SetFloat("TotalAvgSum1", SavedAvgTotal1);
            }

            if (day1.DayOfWeek == DayOfWeek.Tuesday)
            {
                int savedAvgPaceWorkouts1 = PlayerPrefs.GetInt("TotalAvgPaceWorkouts2");
                savedAvgPaceWorkouts1 += 1;
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", savedAvgPaceWorkouts1);

                float SavedAvgSum1 = PlayerPrefs.GetFloat("AveragesSum2");
                SavedAvgSum1 += pushtimeavg;
                PlayerPrefs.SetFloat("AveragesSum2", SavedAvgSum1);

                float SavedAvgTotal1 = SavedAvgSum1 / savedAvgPaceWorkouts1;
                PlayerPrefs.SetFloat("TotalAvgSum2", SavedAvgTotal1);
            }

            if (day1.DayOfWeek == DayOfWeek.Wednesday)
            {
                int savedAvgPaceWorkouts1 = PlayerPrefs.GetInt("TotalAvgPaceWorkouts3");
                savedAvgPaceWorkouts1 += 1;
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", savedAvgPaceWorkouts1);

                float SavedAvgSum1 = PlayerPrefs.GetFloat("AveragesSum3");
                SavedAvgSum1 += pushtimeavg;
                PlayerPrefs.SetFloat("AveragesSum3", SavedAvgSum1);

                float SavedAvgTotal1 = SavedAvgSum1 / savedAvgPaceWorkouts1;
                PlayerPrefs.SetFloat("TotalAvgSum3", SavedAvgTotal1);
            }

            if (day1.DayOfWeek == DayOfWeek.Thursday)
            {
                int savedAvgPaceWorkouts1 = PlayerPrefs.GetInt("TotalAvgPaceWorkouts4");
                savedAvgPaceWorkouts1 += 1;
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", savedAvgPaceWorkouts1);

                float SavedAvgSum1 = PlayerPrefs.GetFloat("AveragesSum4");
                SavedAvgSum1 += pushtimeavg;
                PlayerPrefs.SetFloat("AveragesSum4", SavedAvgSum1);

                float SavedAvgTotal1 = SavedAvgSum1 / savedAvgPaceWorkouts1;
                PlayerPrefs.SetFloat("TotalAvgSum4", SavedAvgTotal1);
            }

            if (day1.DayOfWeek == DayOfWeek.Friday)
            {
                int savedAvgPaceWorkouts1 = PlayerPrefs.GetInt("TotalAvgPaceWorkouts5");
                savedAvgPaceWorkouts1 += 1;
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", savedAvgPaceWorkouts1);

                float SavedAvgSum1 = PlayerPrefs.GetFloat("AveragesSum5");
                SavedAvgSum1 += pushtimeavg;
                PlayerPrefs.SetFloat("AveragesSum5", SavedAvgSum1);

                float SavedAvgTotal1 = SavedAvgSum1 / savedAvgPaceWorkouts1;
                PlayerPrefs.SetFloat("TotalAvgSum5", SavedAvgTotal1);
            }

            if (day1.DayOfWeek == DayOfWeek.Saturday)
            {
                int savedAvgPaceWorkouts1 = PlayerPrefs.GetInt("TotalAvgPaceWorkouts6");
                savedAvgPaceWorkouts1 += 1;
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", savedAvgPaceWorkouts1);

                float SavedAvgSum1 = PlayerPrefs.GetFloat("AveragesSum6");
                SavedAvgSum1 += pushtimeavg;
                PlayerPrefs.SetFloat("AveragesSum6", SavedAvgSum1);

                float SavedAvgTotal1 = SavedAvgSum1 / savedAvgPaceWorkouts1;
                PlayerPrefs.SetFloat("TotalAvgSum6", SavedAvgTotal1);
            }

            if (day1.DayOfWeek == DayOfWeek.Sunday)
            {
                int savedAvgPaceWorkouts1 = PlayerPrefs.GetInt("TotalAvgPaceWorkouts7");
                savedAvgPaceWorkouts1 += 1;
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", savedAvgPaceWorkouts1);

                float SavedAvgSum1 = PlayerPrefs.GetFloat("AveragesSum7");
                SavedAvgSum1 += pushtimeavg;
                PlayerPrefs.SetFloat("AveragesSum7", SavedAvgSum1);

                float SavedAvgTotal1 = SavedAvgSum1 / savedAvgPaceWorkouts1;
                PlayerPrefs.SetFloat("TotalAvgSum7", SavedAvgTotal1);
            }
            //daily journal

            float SavedAvgSum = PlayerPrefs.GetFloat("AveragesSum");
            SavedAvgSum += pushtimeavg;
            PlayerPrefs.SetFloat("AveragesSum", SavedAvgSum);

            float SavedAvgTotal = SavedAvgSum / savedAvgPaceWorkouts;
            PlayerPrefs.SetFloat("TotalAvgSum", SavedAvgTotal);
        }
        stop = 0;
    }

    private IEnumerator Cooldown()
    {
        inCooldown = true;
        yield return new WaitForSeconds(cooldownTime);
        inCooldown = false;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Pause1()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("Christian") == 0)
        {
            ChristianButton.SetActive(true);
            ChristianButton1.SetActive(false);
            ChristianText.SetActive(false);
            preessToPlayText.SetActive(true);
            preessToPlayText1.SetActive(true);
        }
        else
        {
            ChristianButton.SetActive(false);
            ChristianButton1.SetActive(true);
            ChristianText.SetActive(true);
            preessToPlayText.SetActive(false);
            preessToPlayText1.SetActive(false);
        }
    }

    public void ResetScores()
    {
        int resetnumber = 0;
        float resetfloat = 0;
        PlayerPrefs.SetInt("TotalPushups", resetnumber);
        PlayerPrefs.SetInt("TotalWorkouts", resetnumber);
        PlayerPrefs.SetInt("TotalAvgPaceWorkouts", resetnumber);
        PlayerPrefs.SetFloat("AveragesSum", resetfloat);
        PlayerPrefs.SetFloat("TotalAvgSum", resetfloat);
        pushupInput.text = PlayerPrefs.GetInt("TotalPushups").ToString();
        workoutsInput.text = PlayerPrefs.GetInt("TotalWorkouts").ToString();
        pushtimeavgInput.text = PlayerPrefs.GetFloat("TotalAvgSum").ToString("F2"); // + " sec.";
    }

    public void CloseMenuScores()
    {
        pushupInput.text = PlayerPrefs.GetInt("TotalPushups").ToString();
        workoutsInput.text = PlayerPrefs.GetInt("TotalWorkouts").ToString();
        pushtimeavgInput.text = PlayerPrefs.GetFloat("TotalAvgSum").ToString("F2"); // + " sec";
    }
}
