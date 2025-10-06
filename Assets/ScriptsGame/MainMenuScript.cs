//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;
//using System.IO;

public class MainMenuScript : MonoBehaviour
{
    public int ok;
    public GameObject logInBadgesText;
    public Text loginText;
    public GameObject logInBadgesText1;
    public Text loginText1;
    public Text dailyText1;
    public Text dailyText2;
    public Text dailyText3;
    public Text dailyText4;
    public Text dailyText5;
    public Text dailyText6;
    public Text dailyText7;
    public Text PushupsText1;
    public Text PaceText1;
    public Text WorkoutsText1;
    public Text PushupsText2;
    public Text PaceText2;
    public Text WorkoutsText2;
    public Text PushupsRecordText1;
    public Text PaceRecordText1;
    public Text WorkoutsRecordText1;
    public Text PushupsRecordText2;
    public Text PaceRecordText2;
    public Text WorkoutsRecordText2;
    public Text DateText;

    public GameObject effectButton1;
    public GameObject effectButton2;
    public GameObject musicButton1;
    public GameObject musicButton2;
    public GameObject effectButton3;
    public GameObject effectButton4;
    public GameObject musicButton3;
    public GameObject musicButton4;
    public GameObject music;
    public GameObject Effect;
    public GameObject badgesButtonLoggedIn;
    public GameObject badgesButtonLoggedOut;
    public GameObject badgesButtonLoggedIn1;
    public GameObject badgesButtonLoggedOut1;

    public GameObject darkMenu;
    public GameObject menu;
    public GameObject darkModeLogin;
    public GameObject lightModeLogin;
    public GameObject darkModeBadges;
    public GameObject lightModeBadges;
    public GameObject darkModeJournal;
    public GameObject lightModeJournal;
    public GameObject pushupScroll;
    public GameObject paceScroll;
    public GameObject workoutsScroll;
    public GameObject darkModeContactInformation;
    public GameObject lightModeContactInformation;
    public GameObject lightModeSettingsMenu;
    public GameObject darkModeSettingsMenu;

    public TMP_Text loginTextTheme;
    public TMP_Text registerTextTheme;
    public TMP_Text userDataTextTheme;
    public TMP_Text scoreboardTextTheme;
    public Text pushupsAchievmentsText;
    public Text workoutsAchievmentsText;
    public Text paceAchievmentsText;
    public Text currentRecordText;
    public Text currentRecordText1;
    public Text currentPushupRecordText;
    public Text currentPaceRecordText;
    public Text currentWorkoutRecordText;
    public Text currentPushupRecordText1;
    public Text currentPaceRecordText1;
    public Text currentWorkoutRecordText1;

    public GameObject imageNo1;
    public GameObject imageYes1;
    public GameObject imageNo2;
    public GameObject imageYes2;
    public GameObject imageNo3;
    public GameObject imageYes3;
    public GameObject imageNo4;
    public GameObject imageYes4;
    public GameObject imageNo5;
    public GameObject imageYes5;
    public GameObject imageNo6;
    public GameObject imageYes6;
    public GameObject imageNo7;
    public GameObject imageYes7;

    public int effect;
    public int muzici;
    public int status;
    public int diferenta;

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    //public void OnApplicationQuit()
    //{
    //    int today1 = System.DateTime.Now.Day;
    //    int month1 = System.DateTime.Now.Month;
    //    int year1 = System.DateTime.Now.Year;

    //    PlayerPrefs.SetInt("YearDay", year1);
    //    PlayerPrefs.SetInt("MonthDay", month1);
    //    PlayerPrefs.SetInt("WeekDay", today1);
    //}

    public void DailyJournal()
    {
        var day1 = System.DateTime.Today;

        string date1 = System.DateTime.Now.ToString("dd/MM/yyyy");

        DateText.text = "Date: " + date1;

        if (day1.DayOfWeek == DayOfWeek.Monday)
        {
            dailyText7.text = "M";
            dailyText6.text = "Su";
            dailyText5.text = "Sa";
            dailyText4.text = "F";
            dailyText3.text = "Th";
            dailyText2.text = "W";
            dailyText1.text = "Tu";
            int monday = PlayerPrefs.GetInt("TotalWorkoutsMon");
            int sunday = PlayerPrefs.GetInt("TotalWorkoutsSun");
            int saturday = PlayerPrefs.GetInt("TotalWorkoutsSat");
            int friday = PlayerPrefs.GetInt("TotalWorkoutsFri");
            int thursday = PlayerPrefs.GetInt("TotalWorkoutsThu");
            int wednesday = PlayerPrefs.GetInt("TotalWorkoutsWed");
            int tuesday = PlayerPrefs.GetInt("TotalWorkoutsTue");

            if(PlayerPrefs.GetFloat("TotalAvgRecord") == 0)
            {
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum1"));
            }

            if(PlayerPrefs.GetFloat("TotalAvgSum1") < PlayerPrefs.GetFloat("TotalAvgRecord") && PlayerPrefs.GetFloat("TotalAvgSum1") != 0)
            {
                PlayerPrefs.SetFloat("TotalAvgLastRecord", PlayerPrefs.GetFloat("TotalAvgRecord"));
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum1"));
            }

            PaceRecordText1.text = PlayerPrefs.GetFloat("TotalAvgRecord").ToString("F2") + " pace";
            PaceRecordText2.text = PlayerPrefs.GetFloat("TotalAvgLastRecord").ToString("F2") + " pace";


            if (PlayerPrefs.GetInt("TotalPushups1") > PlayerPrefs.GetInt("TotalPushupsRecord"))
            {
                PlayerPrefs.SetInt("TotalPushupsLastRecord", PlayerPrefs.GetInt("TotalPushupsRecord"));
                PlayerPrefs.SetInt("TotalPushupsRecord", PlayerPrefs.GetInt("TotalPushups1"));
            }

            if (PlayerPrefs.GetInt("TotalPushupsRecord") == 1)
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushup";
            else
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushupsLastRecord") == 1)
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushup";
            else
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushups";


            if (PlayerPrefs.GetInt("TotalWorkoutsMon") > PlayerPrefs.GetInt("TotalWorkoutsRecord"))
            {
                PlayerPrefs.SetInt("TotalWorkoutsLastRecord", PlayerPrefs.GetInt("TotalWorkoutsRecord"));
                PlayerPrefs.SetInt("TotalWorkoutsRecord", PlayerPrefs.GetInt("TotalWorkoutsMon")); 
            }

            if (PlayerPrefs.GetInt("TotalWorkoutsRecord") == 1)
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workout";
            else
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsLastRecord") == 1)
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workout";
            else
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workouts";

            PlayerPrefs.SetInt("TotalWorkouts2", 0);
            PlayerPrefs.SetInt("TotalWorkouts3", 0);
            PlayerPrefs.SetInt("TotalWorkouts4", 0);
            PlayerPrefs.SetInt("TotalWorkouts5", 0);
            PlayerPrefs.SetInt("TotalWorkouts6", 0);
            PlayerPrefs.SetInt("TotalWorkouts7", 0);

            PlayerPrefs.SetInt("TotalPushups2", 0);
            PlayerPrefs.SetInt("TotalPushups3", 0);
            PlayerPrefs.SetInt("TotalPushups4", 0);
            PlayerPrefs.SetInt("TotalPushups5", 0);
            PlayerPrefs.SetInt("TotalPushups6", 0);

            PlayerPrefs.SetFloat("TotalAvgSum2", 0);
            PlayerPrefs.SetFloat("AveragesSum2", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
            PlayerPrefs.SetFloat("TotalAvgSum3", 0);
            PlayerPrefs.SetFloat("AveragesSum3", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
            PlayerPrefs.SetFloat("TotalAvgSum4", 0);
            PlayerPrefs.SetFloat("AveragesSum4", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
            PlayerPrefs.SetFloat("TotalAvgSum5", 0);
            PlayerPrefs.SetFloat("AveragesSum5", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
            PlayerPrefs.SetFloat("TotalAvgSum6", 0);
            PlayerPrefs.SetFloat("AveragesSum6", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);

            //int DayNow = System.DateTime.Now.Day;

            //int today1 = PlayerPrefs.GetInt("MondayDay");
            //if (today1 != DayNow)
            //{
            //    PlayerPrefs.SetInt("TotalWorkoutsMon", 0);
            //    PlayerPrefs.SetInt("TotalWorkouts1", 0);
            //    PlayerPrefs.SetInt("MondayDay", DayNow);
            //}

            PaceText1.text = PlayerPrefs.GetFloat("TotalAvgSum1").ToString("F2") + " pace";
            PaceText2.text = PlayerPrefs.GetFloat("TotalAvgSum7").ToString("F2") + " pace";

            if (PlayerPrefs.GetInt("TotalPushups1") == 1)
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups1") + " pushup";
            else
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups1") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushups7") == 1)
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups7") + " pushup";
            else
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups7") + " pushups";

            if (PlayerPrefs.GetInt("TotalWorkouts1") == 1)
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts1") + " workout";
            else
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts1") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsSun") == 1)
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsSun") + " workout";
            else
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsSun") + " workouts";

            //monday
            if (0 < monday)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (monday == 0)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //tuesday
            if (0 < tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //wednesday
            if (0 < wednesday)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (wednesday == 0)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //thursday
            if (0 < thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //friday
            if (0 < friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //saturday
            if (0 < saturday)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (saturday == 0)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //sunday
            if (0 < sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Tuesday)
        {
            dailyText7.text = "Tu";
            dailyText6.text = "M";
            dailyText5.text = "Su";
            dailyText4.text = "Sa";
            dailyText3.text = "F";
            dailyText2.text = "Th";
            dailyText1.text = "W";
            int monday = PlayerPrefs.GetInt("TotalWorkoutsMon");
            int sunday = PlayerPrefs.GetInt("TotalWorkoutsSun");
            int saturday = PlayerPrefs.GetInt("TotalWorkoutsSat");
            int friday = PlayerPrefs.GetInt("TotalWorkoutsFri");
            int thursday = PlayerPrefs.GetInt("TotalWorkoutsThu");
            int wednesday = PlayerPrefs.GetInt("TotalWorkoutsWed");
            int tuesday = PlayerPrefs.GetInt("TotalWorkoutsTue");

            if (PlayerPrefs.GetFloat("TotalAvgRecord") == 0)
            {
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum2"));
            }

            if (PlayerPrefs.GetFloat("TotalAvgSum2") < PlayerPrefs.GetFloat("TotalAvgRecord") && PlayerPrefs.GetFloat("TotalAvgSum2") != 0)
            {
                PlayerPrefs.SetFloat("TotalAvgLastRecord", PlayerPrefs.GetFloat("TotalAvgRecord"));
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum2"));
            }

            PaceRecordText1.text = PlayerPrefs.GetFloat("TotalAvgRecord").ToString("F2") + " pace";
            PaceRecordText2.text = PlayerPrefs.GetFloat("TotalAvgLastRecord").ToString("F2") + " pace";


            if (PlayerPrefs.GetInt("TotalPushups2") > PlayerPrefs.GetInt("TotalPushupsRecord"))
            {
                PlayerPrefs.SetInt("TotalPushupsLastRecord", PlayerPrefs.GetInt("TotalPushupsRecord"));
                PlayerPrefs.SetInt("TotalPushupsRecord", PlayerPrefs.GetInt("TotalPushups2"));
            }

            if (PlayerPrefs.GetInt("TotalPushupsRecord") == 1)
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushup";
            else
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushupsLastRecord") == 1)
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushup";
            else
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushups";


            if (PlayerPrefs.GetInt("TotalWorkoutsTue") > PlayerPrefs.GetInt("TotalWorkoutsRecord"))
            {
                PlayerPrefs.SetInt("TotalWorkoutsLastRecord", PlayerPrefs.GetInt("TotalWorkoutsRecord"));
                PlayerPrefs.SetInt("TotalWorkoutsRecord", PlayerPrefs.GetInt("TotalWorkoutsTue"));
            }

            if (PlayerPrefs.GetInt("TotalWorkoutsRecord") == 1)
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workout";
            else
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsLastRecord") == 1)
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workout";
            else
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workouts";

            PlayerPrefs.SetInt("TotalWorkouts1", 0);
            PlayerPrefs.SetInt("TotalWorkouts3", 0);
            PlayerPrefs.SetInt("TotalWorkouts4", 0);
            PlayerPrefs.SetInt("TotalWorkouts5", 0);
            PlayerPrefs.SetInt("TotalWorkouts6", 0);
            PlayerPrefs.SetInt("TotalWorkouts7", 0);

            PlayerPrefs.SetInt("TotalPushups7", 0);
            PlayerPrefs.SetInt("TotalPushups3", 0);
            PlayerPrefs.SetInt("TotalPushups4", 0);
            PlayerPrefs.SetInt("TotalPushups5", 0);
            PlayerPrefs.SetInt("TotalPushups6", 0);

            PlayerPrefs.SetFloat("TotalAvgSum7", 0);
            PlayerPrefs.SetFloat("AveragesSum7", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
            PlayerPrefs.SetFloat("TotalAvgSum3", 0);
            PlayerPrefs.SetFloat("AveragesSum3", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
            PlayerPrefs.SetFloat("TotalAvgSum4", 0);
            PlayerPrefs.SetFloat("AveragesSum4", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
            PlayerPrefs.SetFloat("TotalAvgSum5", 0);
            PlayerPrefs.SetFloat("AveragesSum5", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
            PlayerPrefs.SetFloat("TotalAvgSum6", 0);
            PlayerPrefs.SetFloat("AveragesSum6", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);

            //int DayNow = System.DateTime.Now.Day;

            //int today1 = PlayerPrefs.GetInt("TuesdayDay");
            //if (today1 != DayNow)
            //{
            //    PlayerPrefs.SetInt("TotalWorkoutsTue", 0);
            //    PlayerPrefs.SetInt("TotalWorkouts2", 0);
            //    PlayerPrefs.SetInt("TuesdayDay", DayNow);
            //}

            PaceText1.text = PlayerPrefs.GetFloat("TotalAvgSum2").ToString("F2") + " pace";
            PaceText2.text = PlayerPrefs.GetFloat("TotalAvgSum1").ToString("F2") + " pace";

            if (PlayerPrefs.GetInt("TotalPushups2") == 1)
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups2") + " pushup";
            else
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups2") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushups1") == 1)
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups1") + " pushup";
            else
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups1") + " pushups";

            if (PlayerPrefs.GetInt("TotalWorkouts2") == 1)
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts2") + " workout";
            else
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts2") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsMon") == 1)
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsMon") + " workout";
            else
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsMon") + " workouts";

            //monday
            if (0 < monday)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (monday == 0)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //tuesday
            if (0 < tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //wednesday
            if (0 < wednesday)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (wednesday == 0)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //thursday
            if (0 < thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //friday
            if (0 < friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //saturday
            if (0 < saturday)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (saturday == 0)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //sunday
            if (0 < sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Wednesday)
        {
            dailyText7.text = "W";
            dailyText6.text = "Tu";
            dailyText5.text = "M";
            dailyText4.text = "Su";
            dailyText3.text = "Sa";
            dailyText2.text = "F";
            dailyText1.text = "Th";
            int monday = PlayerPrefs.GetInt("TotalWorkoutsMon");
            int sunday = PlayerPrefs.GetInt("TotalWorkoutsSun");
            int saturday = PlayerPrefs.GetInt("TotalWorkoutsSat");
            int friday = PlayerPrefs.GetInt("TotalWorkoutsFri");
            int thursday = PlayerPrefs.GetInt("TotalWorkoutsThu");
            int wednesday = PlayerPrefs.GetInt("TotalWorkoutsWed");
            int tuesday = PlayerPrefs.GetInt("TotalWorkoutsTue");

            if (PlayerPrefs.GetFloat("TotalAvgRecord") == 0)
            {
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum3"));
            }

            if (PlayerPrefs.GetFloat("TotalAvgSum3") < PlayerPrefs.GetFloat("TotalAvgRecord") && PlayerPrefs.GetFloat("TotalAvgSum3") != 0)
            {
                PlayerPrefs.SetFloat("TotalAvgLastRecord", PlayerPrefs.GetFloat("TotalAvgRecord"));
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum3"));
            }

            PaceRecordText1.text = PlayerPrefs.GetFloat("TotalAvgRecord").ToString("F2") + " pace";
            PaceRecordText2.text = PlayerPrefs.GetFloat("TotalAvgLastRecord").ToString("F2") + " pace";


            if (PlayerPrefs.GetInt("TotalPushups3") > PlayerPrefs.GetInt("TotalPushupsRecord"))
            {
                PlayerPrefs.SetInt("TotalPushupsLastRecord", PlayerPrefs.GetInt("TotalPushupsRecord"));
                PlayerPrefs.SetInt("TotalPushupsRecord", PlayerPrefs.GetInt("TotalPushups3"));
            }

            if (PlayerPrefs.GetInt("TotalPushupsRecord") == 1)
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushup";
            else
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushupsLastRecord") == 1)
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushup";
            else
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushups";


            if (PlayerPrefs.GetInt("TotalWorkoutsWed") > PlayerPrefs.GetInt("TotalWorkoutsRecord"))
            {
                PlayerPrefs.SetInt("TotalWorkoutsLastRecord", PlayerPrefs.GetInt("TotalWorkoutsRecord"));
                PlayerPrefs.SetInt("TotalWorkoutsRecord", PlayerPrefs.GetInt("TotalWorkoutsWed"));
            }

            if (PlayerPrefs.GetInt("TotalWorkoutsRecord") == 1)
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workout";
            else
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsLastRecord") == 1)
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workout";
            else
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workouts";

            PlayerPrefs.SetInt("TotalWorkouts2", 0);
            PlayerPrefs.SetInt("TotalWorkouts1", 0);
            PlayerPrefs.SetInt("TotalWorkouts4", 0);
            PlayerPrefs.SetInt("TotalWorkouts5", 0);
            PlayerPrefs.SetInt("TotalWorkouts6", 0);
            PlayerPrefs.SetInt("TotalWorkouts7", 0);

            PlayerPrefs.SetInt("TotalPushups7", 0);
            PlayerPrefs.SetInt("TotalPushups1", 0);
            PlayerPrefs.SetInt("TotalPushups4", 0);
            PlayerPrefs.SetInt("TotalPushups5", 0);
            PlayerPrefs.SetInt("TotalPushups6", 0);

            PlayerPrefs.SetFloat("TotalAvgSum1", 0);
            PlayerPrefs.SetFloat("AveragesSum1", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
            PlayerPrefs.SetFloat("TotalAvgSum7", 0);
            PlayerPrefs.SetFloat("AveragesSum7", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
            PlayerPrefs.SetFloat("TotalAvgSum4", 0);
            PlayerPrefs.SetFloat("AveragesSum4", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
            PlayerPrefs.SetFloat("TotalAvgSum5", 0);
            PlayerPrefs.SetFloat("AveragesSum5", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
            PlayerPrefs.SetFloat("TotalAvgSum6", 0);
            PlayerPrefs.SetFloat("AveragesSum6", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);

            //int DayNow = System.DateTime.Now.Day;

            //int today1 = PlayerPrefs.GetInt("WednesdayDay");
            //if (today1 != DayNow)
            //{
            //    PlayerPrefs.SetInt("TotalWorkoutsWed", 0);
            //    PlayerPrefs.SetInt("TotalWorkouts3", 0);
            //    PlayerPrefs.SetInt("WednesdayDay", DayNow);
            //}

            PaceText1.text = PlayerPrefs.GetFloat("TotalAvgSum3").ToString("F2") + " pace";
            PaceText2.text = PlayerPrefs.GetFloat("TotalAvgSum2").ToString("F2") + " pace";

            if (PlayerPrefs.GetInt("TotalPushups3") == 1)
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups3") + " pushup";
            else
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups3") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushups2") == 1)
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups2") + " pushup";
            else
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups2") + " pushups";

            if (PlayerPrefs.GetInt("TotalWorkouts3") == 1)
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts3") + " workout";
            else
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts3") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsTue") == 1)
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsTue") + " workout";
            else
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsTue") + " workouts";

            //monday
            if (0 < monday)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (monday == 0)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //tuesday
            if (0 < tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //wednesday
            if (0 < wednesday)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (wednesday == 0)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //thursday
            if (0 < thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //friday
            if (0 < friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //saturday
            if (0 < saturday)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (saturday == 0)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //sunday
            if (0 < sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Thursday)
        {
            dailyText7.text = "Th";
            dailyText6.text = "W";
            dailyText5.text = "Tu";
            dailyText4.text = "M";
            dailyText3.text = "Su";
            dailyText2.text = "Sa";
            dailyText1.text = "F";
 
            //int DayNow = System.DateTime.Now.Day;

            //int today1 = PlayerPrefs.GetInt("ThursdayDay");
            //if (today1 != DayNow)
            //{
            //    PlayerPrefs.SetInt("TotalWorkoutsThu", 0);
            //    PlayerPrefs.SetInt("TotalWorkouts4", 0);
            //    PlayerPrefs.SetInt("ThursdayDay", DayNow);
            //}

            int monday = PlayerPrefs.GetInt("TotalWorkoutsMon");
            int sunday = PlayerPrefs.GetInt("TotalWorkoutsSun");
            int saturday = PlayerPrefs.GetInt("TotalWorkoutsSat");
            int friday = PlayerPrefs.GetInt("TotalWorkoutsFri");
            int thursday = PlayerPrefs.GetInt("TotalWorkoutsThu");
            int wednesday = PlayerPrefs.GetInt("TotalWorkoutsWed");
            int tuesday = PlayerPrefs.GetInt("TotalWorkoutsTue");

            if (PlayerPrefs.GetFloat("TotalAvgRecord") == 0)
            {
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum4"));
            }

            if (PlayerPrefs.GetFloat("TotalAvgSum4") < PlayerPrefs.GetFloat("TotalAvgRecord") && PlayerPrefs.GetFloat("TotalAvgSum4") != 0)
            {
                PlayerPrefs.SetFloat("TotalAvgLastRecord", PlayerPrefs.GetFloat("TotalAvgRecord"));
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum4"));
            }

            PaceRecordText1.text = PlayerPrefs.GetFloat("TotalAvgRecord").ToString("F2") + " pace";
            PaceRecordText2.text = PlayerPrefs.GetFloat("TotalAvgLastRecord").ToString("F2") + " pace";


            if (PlayerPrefs.GetInt("TotalPushups4") > PlayerPrefs.GetInt("TotalPushupsRecord"))
            {
                PlayerPrefs.SetInt("TotalPushupsLastRecord", PlayerPrefs.GetInt("TotalPushupsRecord"));
                PlayerPrefs.SetInt("TotalPushupsRecord", PlayerPrefs.GetInt("TotalPushups4"));
            }

            if (PlayerPrefs.GetInt("TotalPushupsRecord") == 1)
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushup";
            else
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushupsLastRecord") == 1)
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushup";
            else
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushups";


            if (PlayerPrefs.GetInt("TotalWorkoutsThu") > PlayerPrefs.GetInt("TotalWorkoutsRecord"))
            {
                PlayerPrefs.SetInt("TotalWorkoutsLastRecord", PlayerPrefs.GetInt("TotalWorkoutsRecord"));
                PlayerPrefs.SetInt("TotalWorkoutsRecord", PlayerPrefs.GetInt("TotalWorkoutsThu"));
            }

            if (PlayerPrefs.GetInt("TotalWorkoutsRecord") == 1)
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workout";
            else
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsLastRecord") == 1)
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workout";
            else
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workouts";

            PlayerPrefs.SetInt("TotalWorkouts2", 0);
            PlayerPrefs.SetInt("TotalWorkouts3", 0);
            PlayerPrefs.SetInt("TotalWorkouts1", 0);
            PlayerPrefs.SetInt("TotalWorkouts5", 0);
            PlayerPrefs.SetInt("TotalWorkouts6", 0);
            PlayerPrefs.SetInt("TotalWorkouts7", 0);

            PlayerPrefs.SetInt("TotalPushups1", 0);
            PlayerPrefs.SetInt("TotalPushups2", 0);
            PlayerPrefs.SetInt("TotalPushups7", 0);
            PlayerPrefs.SetInt("TotalPushups5", 0);
            PlayerPrefs.SetInt("TotalPushups6", 0);

            PlayerPrefs.SetFloat("TotalAvgSum2", 0);
            PlayerPrefs.SetFloat("AveragesSum2", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
            PlayerPrefs.SetFloat("TotalAvgSum7", 0);
            PlayerPrefs.SetFloat("AveragesSum7", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
            PlayerPrefs.SetFloat("TotalAvgSum1", 0);
            PlayerPrefs.SetFloat("AveragesSum1", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
            PlayerPrefs.SetFloat("TotalAvgSum5", 0);
            PlayerPrefs.SetFloat("AveragesSum5", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
            PlayerPrefs.SetFloat("TotalAvgSum6", 0);
            PlayerPrefs.SetFloat("AveragesSum6", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);

            PaceText1.text = PlayerPrefs.GetFloat("TotalAvgSum4").ToString("F2") + " pace";
            PaceText2.text = PlayerPrefs.GetFloat("TotalAvgSum3").ToString("F2") + " pace";

            if (PlayerPrefs.GetInt("TotalPushups4") == 1)
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups4") + " pushup";
            else
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups4") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushups3") == 1)
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups3") + " pushup";
            else
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups3") + " pushups";

            if (PlayerPrefs.GetInt("TotalWorkouts4") == 1)
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts4") + " workout";
            else
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts4") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsWed") == 1)
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsWed") + " workout";
            else
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsWed") + " workouts";

            //monday
            if (0 < monday)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (monday == 0)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //tuesday
            if (0 < tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //wednesday
            if (0 < wednesday)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (wednesday == 0)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //thursday
            if (0 < thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //friday
            if (0 < friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //saturday
            if (0 < saturday)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (saturday == 0)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //sunday
            if (0 < sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Friday)
        {
            dailyText7.text = "F";
            dailyText6.text = "Th";
            dailyText5.text = "W";
            dailyText4.text = "Tu";
            dailyText3.text = "M";
            dailyText2.text = "Su";
            dailyText1.text = "Sa";
            int monday = PlayerPrefs.GetInt("TotalWorkoutsMon");
            int sunday = PlayerPrefs.GetInt("TotalWorkoutsSun");
            int saturday = PlayerPrefs.GetInt("TotalWorkoutsSat");
            int friday = PlayerPrefs.GetInt("TotalWorkoutsFri");
            int thursday = PlayerPrefs.GetInt("TotalWorkoutsThu");
            int wednesday = PlayerPrefs.GetInt("TotalWorkoutsWed");
            int tuesday = PlayerPrefs.GetInt("TotalWorkoutsTue");

            if (PlayerPrefs.GetFloat("TotalAvgRecord") == 0)
            {
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum5"));
            }

            if (PlayerPrefs.GetFloat("TotalAvgSum5") < PlayerPrefs.GetFloat("TotalAvgRecord") && PlayerPrefs.GetFloat("TotalAvgSum5") != 0)
            {
                PlayerPrefs.SetFloat("TotalAvgLastRecord", PlayerPrefs.GetFloat("TotalAvgRecord"));
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum5"));
            }

            PaceRecordText1.text = PlayerPrefs.GetFloat("TotalAvgRecord").ToString("F2") + " pace";
            PaceRecordText2.text = PlayerPrefs.GetFloat("TotalAvgLastRecord").ToString("F2") + " pace";


            if (PlayerPrefs.GetInt("TotalPushups5") > PlayerPrefs.GetInt("TotalPushupsRecord"))
            {
                PlayerPrefs.SetInt("TotalPushupsLastRecord", PlayerPrefs.GetInt("TotalPushupsRecord"));
                PlayerPrefs.SetInt("TotalPushupsRecord", PlayerPrefs.GetInt("TotalPushups5"));
            }

            if (PlayerPrefs.GetInt("TotalPushupsRecord") == 1)
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushup";
            else
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushupsLastRecord") == 1)
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushup";
            else
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushups";


            if (PlayerPrefs.GetInt("TotalWorkoutsFri") > PlayerPrefs.GetInt("TotalWorkoutsRecord"))
            {
                PlayerPrefs.SetInt("TotalWorkoutsLastRecord", PlayerPrefs.GetInt("TotalWorkoutsRecord"));
                PlayerPrefs.SetInt("TotalWorkoutsRecord", PlayerPrefs.GetInt("TotalWorkoutsFri"));
            }

            if (PlayerPrefs.GetInt("TotalWorkoutsRecord") == 1)
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workout";
            else
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsLastRecord") == 1)
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workout";
            else
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workouts";

            PlayerPrefs.SetInt("TotalWorkouts2", 0);
            PlayerPrefs.SetInt("TotalWorkouts3", 0);
            PlayerPrefs.SetInt("TotalWorkouts4", 0);
            PlayerPrefs.SetInt("TotalWorkouts1", 0);
            PlayerPrefs.SetInt("TotalWorkouts6", 0);
            PlayerPrefs.SetInt("TotalWorkouts7", 0);

            PlayerPrefs.SetInt("TotalPushups1", 0);
            PlayerPrefs.SetInt("TotalPushups2", 0);
            PlayerPrefs.SetInt("TotalPushups3", 0);
            PlayerPrefs.SetInt("TotalPushups7", 0);
            PlayerPrefs.SetInt("TotalPushups6", 0);

            PlayerPrefs.SetFloat("TotalAvgSum2", 0);
            PlayerPrefs.SetFloat("AveragesSum2", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
            PlayerPrefs.SetFloat("TotalAvgSum3", 0);
            PlayerPrefs.SetFloat("AveragesSum3", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
            PlayerPrefs.SetFloat("TotalAvgSum1", 0);
            PlayerPrefs.SetFloat("AveragesSum1", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
            PlayerPrefs.SetFloat("TotalAvgSum7", 0);
            PlayerPrefs.SetFloat("AveragesSum7", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
            PlayerPrefs.SetFloat("TotalAvgSum6", 0);
            PlayerPrefs.SetFloat("AveragesSum6", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);

            //sistem de verificare a trecerii zilei saptamanii
            //int DayNow = System.DateTime.Now.Day;

            //int today1 = PlayerPrefs.GetInt("FridayDay");
            //if (today1 != DayNow)
            //{
            //    PlayerPrefs.SetInt("TotalWorkoutsFri", 0);
            //    PlayerPrefs.SetInt("TotalWorkouts5", 0);
            //    PlayerPrefs.SetInt("FridayDay", DayNow);
            //}
            //sistem de verificare a trecerii zilei saptamanii

            PaceText1.text = PlayerPrefs.GetFloat("TotalAvgSum5").ToString("F2") + " pace";
            PaceText2.text = PlayerPrefs.GetFloat("TotalAvgSum4").ToString("F2") + " pace";

            if (PlayerPrefs.GetInt("TotalPushups5") == 1)
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups5") + " pushup";
            else
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups5") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushups4") == 1)
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups4") + " pushup";
            else
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups4") + " pushups";

            if (PlayerPrefs.GetInt("TotalWorkouts5") == 1)
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts5") + " workout";
            else
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts5") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsThu") == 1)
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsThu") + " workout";
            else
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsThu") + " workouts";

            //monday
            if (0 < monday)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (monday == 0)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //tuesday
            if (0 < tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //wednesday
            if (0 < wednesday)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (wednesday == 0)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //thursday
            if (0 < thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //friday
            if (0 < friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //saturday
            if (0 < saturday)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (saturday == 0)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //sunday
            if (0 < sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Saturday)
        {
            dailyText7.text = "Sa";
            dailyText6.text = "F";
            dailyText5.text = "Th";
            dailyText4.text = "W";
            dailyText3.text = "Tu";
            dailyText2.text = "M";
            dailyText1.text = "Su";
            int monday = PlayerPrefs.GetInt("TotalWorkoutsMon");
            int sunday = PlayerPrefs.GetInt("TotalWorkoutsSun");
            int saturday = PlayerPrefs.GetInt("TotalWorkoutsSat");
            int friday = PlayerPrefs.GetInt("TotalWorkoutsFri");
            int thursday = PlayerPrefs.GetInt("TotalWorkoutsThu");
            int wednesday = PlayerPrefs.GetInt("TotalWorkoutsWed");
            int tuesday = PlayerPrefs.GetInt("TotalWorkoutsTue");

            if (PlayerPrefs.GetFloat("TotalAvgRecord") == 0)
            {
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum6"));
            }

            if (PlayerPrefs.GetFloat("TotalAvgSum6") < PlayerPrefs.GetFloat("TotalAvgRecord") && PlayerPrefs.GetFloat("TotalAvgSum6") != 0)
            {
                PlayerPrefs.SetFloat("TotalAvgLastRecord", PlayerPrefs.GetFloat("TotalAvgRecord"));
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum6"));
            }

            PaceRecordText1.text = PlayerPrefs.GetFloat("TotalAvgRecord").ToString("F2") + " pace";
            PaceRecordText2.text = PlayerPrefs.GetFloat("TotalAvgLastRecord").ToString("F2") + " pace";


            if (PlayerPrefs.GetInt("TotalPushups6") > PlayerPrefs.GetInt("TotalPushupsRecord"))
            {
                PlayerPrefs.SetInt("TotalPushupsLastRecord", PlayerPrefs.GetInt("TotalPushupsRecord"));
                PlayerPrefs.SetInt("TotalPushupsRecord", PlayerPrefs.GetInt("TotalPushups6"));
            }

            if (PlayerPrefs.GetInt("TotalPushupsRecord") == 1)
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushup";
            else
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushupsLastRecord") == 1)
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushup";
            else
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushups";


            if (PlayerPrefs.GetInt("TotalWorkoutsSat") > PlayerPrefs.GetInt("TotalWorkoutsRecord"))
            {
                PlayerPrefs.SetInt("TotalWorkoutsLastRecord", PlayerPrefs.GetInt("TotalWorkoutsRecord"));
                PlayerPrefs.SetInt("TotalWorkoutsRecord", PlayerPrefs.GetInt("TotalWorkoutsSat"));
            }

            if (PlayerPrefs.GetInt("TotalWorkoutsRecord") == 1)
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workout";
            else
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsLastRecord") == 1)
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workout";
            else
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workouts";

            PlayerPrefs.SetInt("TotalWorkouts2", 0);
            PlayerPrefs.SetInt("TotalWorkouts3", 0);
            PlayerPrefs.SetInt("TotalWorkouts4", 0);
            PlayerPrefs.SetInt("TotalWorkouts5", 0);
            PlayerPrefs.SetInt("TotalWorkouts1", 0);
            PlayerPrefs.SetInt("TotalWorkouts7", 0);

            PlayerPrefs.SetInt("TotalPushups1", 0);
            PlayerPrefs.SetInt("TotalPushups2", 0);
            PlayerPrefs.SetInt("TotalPushups3", 0);
            PlayerPrefs.SetInt("TotalPushups4", 0);
            PlayerPrefs.SetInt("TotalPushups7", 0);

            PlayerPrefs.SetFloat("TotalAvgSum2", 0);
            PlayerPrefs.SetFloat("AveragesSum2", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
            PlayerPrefs.SetFloat("TotalAvgSum3", 0);
            PlayerPrefs.SetFloat("AveragesSum3", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
            PlayerPrefs.SetFloat("TotalAvgSum4", 0);
            PlayerPrefs.SetFloat("AveragesSum4", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
            PlayerPrefs.SetFloat("TotalAvgSum1", 0);
            PlayerPrefs.SetFloat("AveragesSum1", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
            PlayerPrefs.SetFloat("TotalAvgSum7", 0);
            PlayerPrefs.SetFloat("AveragesSum7", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);

            //sistem de verificare a trecerii zilei saptamanii
            //int DayNow = System.DateTime.Now.Day;

            //int today1 = PlayerPrefs.GetInt("SaturdayDay");
            //if (today1 != DayNow)
            //{
            //    PlayerPrefs.SetInt("TotalWorkoutsSat", 0);
            //    PlayerPrefs.SetInt("TotalWorkouts6", 0);
            //    PlayerPrefs.SetInt("SaturdayDay", DayNow);
            //}
            //sistem de verificare a trecerii zilei saptamanii

            PaceText1.text = PlayerPrefs.GetFloat("TotalAvgSum6").ToString("F2") + " pace";
            PaceText2.text = PlayerPrefs.GetFloat("TotalAvgSum5").ToString("F2") + " pace";

            if (PlayerPrefs.GetInt("TotalPushups6") == 1)
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups6") + " pushup";
            else
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups6") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushups5") == 1)
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups5") + " pushup";
            else
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups5") + " pushups";

            if (PlayerPrefs.GetInt("TotalWorkouts6") == 1)
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts6") + " workout";
            else
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts6") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsFri") == 1)
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsFri") + " workout";
            else
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsFri") + " workouts";

            //monday
            if (0 < monday)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (monday == 0)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //tuesday
            if (0 < tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //wednesday
            if (0 < wednesday)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (wednesday == 0)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //thursday
            if (0 < thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //friday
            if (0 < friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //saturday
            if (0 < saturday)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (saturday == 0)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //sunday
            if (0 < sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Sunday)
        {
            dailyText7.text = "Su";
            dailyText6.text = "Sa";
            dailyText5.text = "F";
            dailyText4.text = "Th";
            dailyText3.text = "W";
            dailyText2.text = "Tu";
            dailyText1.text = "M";
            int monday = PlayerPrefs.GetInt("TotalWorkoutsMon");
            int sunday = PlayerPrefs.GetInt("TotalWorkoutsSun");
            int saturday = PlayerPrefs.GetInt("TotalWorkoutsSat");
            int friday = PlayerPrefs.GetInt("TotalWorkoutsFri");
            int thursday = PlayerPrefs.GetInt("TotalWorkoutsThu");
            int wednesday = PlayerPrefs.GetInt("TotalWorkoutsWed");
            int tuesday = PlayerPrefs.GetInt("TotalWorkoutsTue");

            if (PlayerPrefs.GetFloat("TotalAvgRecord") == 0)
            {
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum7"));
            }

            if (PlayerPrefs.GetFloat("TotalAvgSum7") < PlayerPrefs.GetFloat("TotalAvgRecord") && PlayerPrefs.GetFloat("TotalAvgSum7") != 0)
            {
                PlayerPrefs.SetFloat("TotalAvgLastRecord", PlayerPrefs.GetFloat("TotalAvgRecord"));
                PlayerPrefs.SetFloat("TotalAvgRecord", PlayerPrefs.GetFloat("TotalAvgSum7"));
            }

            PaceRecordText1.text = PlayerPrefs.GetFloat("TotalAvgRecord").ToString("F2") + " pace";
            PaceRecordText2.text = PlayerPrefs.GetFloat("TotalAvgLastRecord").ToString("F2") + " pace";


            if (PlayerPrefs.GetInt("TotalPushups7") > PlayerPrefs.GetInt("TotalPushupsRecord"))
            {
                PlayerPrefs.SetInt("TotalPushupsLastRecord", PlayerPrefs.GetInt("TotalPushupsRecord"));
                PlayerPrefs.SetInt("TotalPushupsRecord", PlayerPrefs.GetInt("TotalPushups7"));
            }

            if (PlayerPrefs.GetInt("TotalPushupsRecord") == 1)
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushup";
            else
                PushupsRecordText1.text = PlayerPrefs.GetInt("TotalPushupsRecord") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushupsLastRecord") == 1)
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushup";
            else
                PushupsRecordText2.text = PlayerPrefs.GetInt("TotalPushupsLastRecord") + " pushups";


            if (PlayerPrefs.GetInt("TotalWorkoutsSun") > PlayerPrefs.GetInt("TotalWorkoutsRecord"))
            {
                PlayerPrefs.SetInt("TotalWorkoutsLastRecord", PlayerPrefs.GetInt("TotalWorkoutsRecord"));
                PlayerPrefs.SetInt("TotalWorkoutsRecord", PlayerPrefs.GetInt("TotalWorkoutsSun"));
            }

            if (PlayerPrefs.GetInt("TotalWorkoutsRecord") == 1)
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workout";
            else
                WorkoutsRecordText1.text = PlayerPrefs.GetInt("TotalWorkoutsRecord") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsLastRecord") == 1)
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workout";
            else
                WorkoutsRecordText2.text = PlayerPrefs.GetInt("TotalWorkoutsLastRecord") + " workouts";

            PlayerPrefs.SetInt("TotalWorkouts2", 0);
            PlayerPrefs.SetInt("TotalWorkouts3", 0);
            PlayerPrefs.SetInt("TotalWorkouts4", 0);
            PlayerPrefs.SetInt("TotalWorkouts5", 0);
            PlayerPrefs.SetInt("TotalWorkouts6", 0);
            PlayerPrefs.SetInt("TotalWorkouts1", 0);

            PlayerPrefs.SetInt("TotalPushups1", 0);
            PlayerPrefs.SetInt("TotalPushups2", 0);
            PlayerPrefs.SetInt("TotalPushups3", 0);
            PlayerPrefs.SetInt("TotalPushups4", 0);
            PlayerPrefs.SetInt("TotalPushups5", 0);

            PlayerPrefs.SetFloat("TotalAvgSum2", 0);
            PlayerPrefs.SetFloat("AveragesSum2", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
            PlayerPrefs.SetFloat("TotalAvgSum3", 0);
            PlayerPrefs.SetFloat("AveragesSum3", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
            PlayerPrefs.SetFloat("TotalAvgSum4", 0);
            PlayerPrefs.SetFloat("AveragesSum4", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
            PlayerPrefs.SetFloat("TotalAvgSum5", 0);
            PlayerPrefs.SetFloat("AveragesSum5", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
            PlayerPrefs.SetFloat("TotalAvgSum1", 0);
            PlayerPrefs.SetFloat("AveragesSum1", 0);
            PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);

            //sistem de verificare a trecerii zilei saptamanii
            //int DayNow = System.DateTime.Now.Day;

            //int today1 = PlayerPrefs.GetInt("SundayDay");
            //if (today1 != DayNow)
            //{
            //    PlayerPrefs.SetInt("TotalWorkoutsSun", 0);
            //    PlayerPrefs.SetInt("TotalWorkouts7", 0);
            //    PlayerPrefs.SetInt("SundayDay", DayNow);
            //}
            //sistem de verificare a trecerii zilei saptamanii

            PaceText1.text = PlayerPrefs.GetFloat("TotalAvgSum7").ToString("F2") + " pace";
            PaceText2.text = PlayerPrefs.GetFloat("TotalAvgSum6").ToString("F2") + " pace";

            if (PlayerPrefs.GetInt("TotalPushups7") == 1)
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups7") + " pushup";
            else
                PushupsText1.text = PlayerPrefs.GetInt("TotalPushups7") + " pushups";

            if (PlayerPrefs.GetInt("TotalPushups6") == 1)
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups6") + " pushup";
            else
                PushupsText2.text = PlayerPrefs.GetInt("TotalPushups6") + " pushups";

            if (PlayerPrefs.GetInt("TotalWorkouts7") == 1)
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts7") + " workout";
            else
                WorkoutsText1.text = PlayerPrefs.GetInt("TotalWorkouts7") + " workouts";

            if (PlayerPrefs.GetInt("TotalWorkoutsSat") == 1)
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsSat") + " workout";
            else
                WorkoutsText2.text = PlayerPrefs.GetInt("TotalWorkoutsSat") + " workouts";

            //monday
            if (0 < monday)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (monday == 0)
            {
                if (dailyText1.text == "M")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "M")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "M")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "M")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "M")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "M")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "M")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //tuesday
            if (0 < tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == tuesday)
            {
                if (dailyText1.text == "Tu")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Tu")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Tu")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Tu")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Tu")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Tu")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Tu")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //wednesday
            if (0 < wednesday)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (wednesday == 0)
            {
                if (dailyText1.text == "W")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "W")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "W")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "W")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "W")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "W")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "W")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //thursday
            if (0 < thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == thursday)
            {
                if (dailyText1.text == "Th")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Th")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Th")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Th")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Th")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Th")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Th")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //friday
            if (0 < friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == friday)
            {
                if (dailyText1.text == "F")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "F")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "F")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "F")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "F")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "F")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "F")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //saturday
            if (0 < saturday)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (saturday == 0)
            {
                if (dailyText1.text == "Sa")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Sa")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Sa")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Sa")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Sa")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Sa")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Sa")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }

            //sunday
            if (0 < sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(true);
                    imageNo1.SetActive(false);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(true);
                    imageNo2.SetActive(false);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(true);
                    imageNo3.SetActive(false);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(true);
                    imageNo4.SetActive(false);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(true);
                    imageNo5.SetActive(false);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(true);
                    imageNo6.SetActive(false);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(true);
                    imageNo7.SetActive(false);
                }
            }

            if (0 == sunday)
            {
                if (dailyText1.text == "Su")
                {
                    imageYes1.SetActive(false);
                    imageNo1.SetActive(true);
                }
                if (dailyText2.text == "Su")
                {
                    imageYes2.SetActive(false);
                    imageNo2.SetActive(true);
                }
                if (dailyText3.text == "Su")
                {
                    imageYes3.SetActive(false);
                    imageNo3.SetActive(true);
                }
                if (dailyText4.text == "Su")
                {
                    imageYes4.SetActive(false);
                    imageNo4.SetActive(true);
                }
                if (dailyText5.text == "Su")
                {
                    imageYes5.SetActive(false);
                    imageNo5.SetActive(true);
                }
                if (dailyText6.text == "Su")
                {
                    imageYes6.SetActive(false);
                    imageNo6.SetActive(true);
                }
                if (dailyText7.text == "Su")
                {
                    imageYes7.SetActive(false);
                    imageNo7.SetActive(true);
                }
            }
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void Start()
    {
        if (PlayerPrefs.GetInt("Theme") == 1)
        {
            darkModeSettingsMenu.SetActive(false);
            lightModeSettingsMenu.SetActive(true);
            darkModeContactInformation.SetActive(false);
            lightModeContactInformation.SetActive(true);
            darkMenu.SetActive(false);
            menu.SetActive(true);
            darkModeLogin.SetActive(false);
            lightModeLogin.SetActive(true);
            darkModeBadges.SetActive(false);
            lightModeBadges.SetActive(true);
            darkModeJournal.SetActive(false);
            lightModeJournal.SetActive(true);
            pushupScroll.GetComponent<Image>().color = new Color(1f, 0.5137255f, 0.1568628f, 1f);
            paceScroll.GetComponent<Image>().color = new Color(0.4392157f, 0.5137255f, 0.7921569f, 1f);
            workoutsScroll.GetComponent<Image>().color = new Color(1f, 0.8000001f, 0.2509804f, 1f);
            pushupsAchievmentsText.color = new Color(0.9843138f, 0.4196079f, 0.2627451f, 1f);
            paceAchievmentsText.color = new Color(0.3882353f, 0.5372549f, 0.8078432f, 1f);
            workoutsAchievmentsText.color = new Color(0.9490197f, 0.8235295f, 0.3098039f, 1f);
            currentRecordText.color = new Color(1f, 1f, 1f, 1f);
            currentRecordText1.color = new Color(1f, 1f, 1f, 1f);
            //currentPushupRecordText.color = new Color(1f, 1f, 1f, 1f);
            //currentPaceRecordText.color = new Color(1f, 1f, 1f, 1f);
            //currentWorkoutRecordText.color = new Color(1f, 1f, 1f, 1f);
            //currentPushupRecordText1.color = new Color(1f, 1f, 1f, 1f);
            //currentPaceRecordText1.color = new Color(1f, 1f, 1f, 1f);
            //currentWorkoutRecordText1.color = new Color(1f, 1f, 1f, 1f);
            dailyText1.color = new Color(1f, 1f, 1f, 1f);
            dailyText2.color = new Color(1f, 1f, 1f, 1f);
            dailyText3.color = new Color(1f, 1f, 1f, 1f);
            dailyText4.color = new Color(1f, 1f, 1f, 1f);
            dailyText5.color = new Color(1f, 1f, 1f, 1f);
            dailyText6.color = new Color(1f, 1f, 1f, 1f);
            dailyText7.color = new Color(1f, 1f, 1f, 1f);
            DateText.color = new Color(0.1960784f, 0.1960784f, 0.1960784f, 1f);
            loginTextTheme.color = new Color(1f, 1f, 1f, 1f);
            registerTextTheme.color = new Color(1f, 1f, 1f, 1f);
            userDataTextTheme.color = new Color(1f, 1f, 1f, 1f);
            scoreboardTextTheme.color = new Color(1f, 1f, 1f, 1f);
        }

        if (PlayerPrefs.GetInt("Theme") == 0)
        {
            darkModeSettingsMenu.SetActive(true);
            lightModeSettingsMenu.SetActive(false);
            darkModeContactInformation.SetActive(true);
            lightModeContactInformation.SetActive(false);
            darkMenu.SetActive(true);
            menu.SetActive(false);
            darkModeLogin.SetActive(true);
            lightModeLogin.SetActive(false);
            darkModeBadges.SetActive(true);
            lightModeBadges.SetActive(false);
            darkModeJournal.SetActive(true);
            lightModeJournal.SetActive(false);
            pushupScroll.GetComponent<Image>().color = new Color(0.3207547f, 0.29861f, 0.2859558f, 1f);
            paceScroll.GetComponent<Image>().color = new Color(0.3207547f, 0.29861f, 0.2859558f, 1f);
            workoutsScroll.GetComponent<Image>().color = new Color(0.3207547f, 0.29861f, 0.2859558f, 1f);
            pushupsAchievmentsText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            paceAchievmentsText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            workoutsAchievmentsText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            currentRecordText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            currentRecordText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            //currentPushupRecordText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            //currentPaceRecordText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            //currentWorkoutRecordText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            //currentPushupRecordText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            //currentPaceRecordText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            //currentWorkoutRecordText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            dailyText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            dailyText2.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            dailyText3.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            dailyText4.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            dailyText5.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            dailyText6.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            dailyText7.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            DateText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            loginTextTheme.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            registerTextTheme.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            userDataTextTheme.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
            scoreboardTextTheme.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        }

        if (PlayerPrefs.GetFloat("TotalAvgRecord") == 0)
        {
            PaceRecordText1.text = "- pace";
        }

        if (PlayerPrefs.GetFloat("TotalAvgLastRecord") == 0)
        {
            PaceRecordText2.text = "- pace";
        }

        int status;
        status = PlayerPrefs.GetInt("LogOut");
        if (status == 10)
        {
            if (PlayerPrefs.GetInt("Theme") == 1)
            {
                logInBadgesText.SetActive(true);
                logInBadgesText1.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Theme") == 0)
            {
                logInBadgesText.SetActive(false);
                logInBadgesText1.SetActive(true);
            }
            loginText.text = "Login/Register";
            loginText1.text = "Login/Register";
            badgesButtonLoggedIn.SetActive(false);
            badgesButtonLoggedOut.SetActive(true);
            badgesButtonLoggedIn1.SetActive(false);
            badgesButtonLoggedOut1.SetActive(true);
        }
        if(status == 1)
        {
            logInBadgesText.SetActive(false);
            loginText.text = "Data/Scoreboard";
            logInBadgesText1.SetActive(false);
            loginText1.text = "Data/Scoreboard";
            badgesButtonLoggedIn.SetActive(true);
            badgesButtonLoggedOut.SetActive(false);
            badgesButtonLoggedIn1.SetActive(true);
            badgesButtonLoggedOut1.SetActive(false);
        }

        effect = PlayerPrefs.GetInt("Effect");
        if (effect == 10)
        {
            effectButton2.SetActive(true);
            effectButton1.SetActive(false);
            effectButton4.SetActive(true);
            effectButton3.SetActive(false);
            Effect.SetActive(false);
        }
        else
        {
            effectButton2.SetActive(false);
            effectButton1.SetActive(true);
            effectButton4.SetActive(false);
            effectButton3.SetActive(true);
            Effect.SetActive(true);
        }

        muzici = PlayerPrefs.GetInt("Music");
        if (muzici == 10)
        {
            musicButton2.SetActive(true);
            musicButton1.SetActive(false);
            musicButton4.SetActive(true);
            musicButton3.SetActive(false);
            music.SetActive(false);
        }
        else
        {
            musicButton2.SetActive(false);
            musicButton1.SetActive(true);
            musicButton4.SetActive(false);
            musicButton3.SetActive(true);
            music.SetActive(true);
        }

    }

    void Update()
    {
        var day1 = System.DateTime.Today;

        if (day1.DayOfWeek == DayOfWeek.Monday)
        {
            int DayNow = System.DateTime.Now.Day;

            int today1 = PlayerPrefs.GetInt("MondayDay");
            if (today1 != DayNow)
            {
                PlayerPrefs.SetFloat("TotalAvgSum1", 0);
                PlayerPrefs.SetFloat("AveragesSum1", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
                PlayerPrefs.SetInt("TotalPushups1", 0);
                PlayerPrefs.SetInt("TotalWorkoutsMon", 0);
                PlayerPrefs.SetInt("TotalWorkouts1", 0);
                PlayerPrefs.SetInt("MondayDay", DayNow);
            }

            int today2 = PlayerPrefs.GetInt("TuesdayDay");
            if (today2 != DayNow - 6)
            {
                PlayerPrefs.SetFloat("TotalAvgSum2", 0);
                PlayerPrefs.SetFloat("AveragesSum2", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
                PlayerPrefs.SetInt("TotalPushups2", 0);
                PlayerPrefs.SetInt("TotalWorkoutsTue", 0);
                PlayerPrefs.SetInt("TotalWorkouts2", 0);
            }

            int today3 = PlayerPrefs.GetInt("WednesdayDay");
            if (today3 != DayNow - 5)
            {
                PlayerPrefs.SetFloat("TotalAvgSum3", 0);
                PlayerPrefs.SetFloat("AveragesSum3", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
                PlayerPrefs.SetInt("TotalPushups3", 0);
                PlayerPrefs.SetInt("TotalWorkoutsWed", 0);
                PlayerPrefs.SetInt("TotalWorkouts3", 0);
            }

            int today4 = PlayerPrefs.GetInt("ThursdayDay");
            if (today4 != DayNow - 4)
            {
                PlayerPrefs.SetFloat("TotalAvgSum4", 0);
                PlayerPrefs.SetFloat("AveragesSum4", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
                PlayerPrefs.SetInt("TotalPushups4", 0);
                PlayerPrefs.SetInt("TotalWorkoutsThu", 0);
                PlayerPrefs.SetInt("TotalWorkouts4", 0);
            }

            int today5 = PlayerPrefs.GetInt("FridayDay");
            if (today5 != DayNow - 3)
            {
                PlayerPrefs.SetFloat("TotalAvgSum5", 0);
                PlayerPrefs.SetFloat("AveragesSum5", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
                PlayerPrefs.SetInt("TotalPushups5", 0);
                PlayerPrefs.SetInt("TotalWorkoutsFri", 0);
                PlayerPrefs.SetInt("TotalWorkouts5", 0);
            }

            int today6 = PlayerPrefs.GetInt("SaturdayDay");
            if (today6 != DayNow - 2)
            {
                PlayerPrefs.SetFloat("TotalAvgSum6", 0);
                PlayerPrefs.SetFloat("AveragesSum6", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);
                PlayerPrefs.SetInt("TotalPushups6", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSat", 0);
                PlayerPrefs.SetInt("TotalWorkouts6", 0);
            }

            int today7 = PlayerPrefs.GetInt("SundayDay");
            if (today7 != DayNow - 1)
            {
                PlayerPrefs.SetFloat("TotalAvgSum7", 0);
                PlayerPrefs.SetFloat("AveragesSum7", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
                PlayerPrefs.SetInt("TotalPushups7", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSun", 0);
                PlayerPrefs.SetInt("TotalWorkouts7", 0);
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Tuesday)
        {
            int DayNow = System.DateTime.Now.Day;

            int today1 = PlayerPrefs.GetInt("MondayDay");
            if (today1 != DayNow - 1)
            {
                PlayerPrefs.SetFloat("TotalAvgSum1", 0);
                PlayerPrefs.SetFloat("AveragesSum1", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
                PlayerPrefs.SetInt("TotalPushups1", 0);
                PlayerPrefs.SetInt("TotalWorkoutsMon", 0);
                PlayerPrefs.SetInt("TotalWorkouts1", 0);
            }

            int today2 = PlayerPrefs.GetInt("TuesdayDay");
            if (today2 != DayNow)
            {
                PlayerPrefs.SetFloat("TotalAvgSum2", 0);
                PlayerPrefs.SetFloat("AveragesSum2", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
                PlayerPrefs.SetInt("TotalPushups2", 0);
                PlayerPrefs.SetInt("TotalWorkoutsTue", 0);
                PlayerPrefs.SetInt("TotalWorkouts2", 0);
                PlayerPrefs.SetInt("TuesdayDay", DayNow);
            }

            int today3 = PlayerPrefs.GetInt("WednesdayDay");
            if (today3 != DayNow - 6)
            {
                PlayerPrefs.SetFloat("TotalAvgSum3", 0);
                PlayerPrefs.SetFloat("AveragesSum3", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
                PlayerPrefs.SetInt("TotalPushups3", 0);
                PlayerPrefs.SetInt("TotalWorkoutsWed", 0);
                PlayerPrefs.SetInt("TotalWorkouts3", 0);
            }

            int today4 = PlayerPrefs.GetInt("ThursdayDay");
            if (today4 != DayNow - 5)
            {
                PlayerPrefs.SetFloat("TotalAvgSum4", 0);
                PlayerPrefs.SetFloat("AveragesSum4", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
                PlayerPrefs.SetInt("TotalPushups4", 0);
                PlayerPrefs.SetInt("TotalWorkoutsThu", 0);
                PlayerPrefs.SetInt("TotalWorkouts4", 0);
            }

            int today5 = PlayerPrefs.GetInt("FridayDay");
            if (today5 != DayNow - 4)
            {
                PlayerPrefs.SetFloat("TotalAvgSum5", 0);
                PlayerPrefs.SetFloat("AveragesSum5", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
                PlayerPrefs.SetInt("TotalPushups5", 0);
                PlayerPrefs.SetInt("TotalWorkoutsFri", 0);
                PlayerPrefs.SetInt("TotalWorkouts5", 0);
            }

            int today6 = PlayerPrefs.GetInt("SaturdayDay");
            if (today6 != DayNow - 3)
            {
                PlayerPrefs.SetFloat("TotalAvgSum6", 0);
                PlayerPrefs.SetFloat("AveragesSum6", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);
                PlayerPrefs.SetInt("TotalPushups6", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSat", 0);
                PlayerPrefs.SetInt("TotalWorkouts6", 0);
            }

            int today7 = PlayerPrefs.GetInt("SundayDay");
            if (today7 != DayNow - 2)
            {
                PlayerPrefs.SetFloat("TotalAvgSum7", 0);
                PlayerPrefs.SetFloat("AveragesSum7", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
                PlayerPrefs.SetInt("TotalPushups7", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSun", 0);
                PlayerPrefs.SetInt("TotalWorkouts7", 0);
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Wednesday)
        {
            int DayNow = System.DateTime.Now.Day;

            int today1 = PlayerPrefs.GetInt("MondayDay");
            if (today1 != DayNow - 2)
            {
                PlayerPrefs.SetFloat("TotalAvgSum1", 0);
                PlayerPrefs.SetFloat("AveragesSum1", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
                PlayerPrefs.SetInt("TotalPushups1", 0);
                PlayerPrefs.SetInt("TotalWorkoutsMon", 0);
                PlayerPrefs.SetInt("TotalWorkouts1", 0);
            }

            int today2 = PlayerPrefs.GetInt("TuesdayDay");
            if (today2 != DayNow - 1)
            {
                PlayerPrefs.SetFloat("TotalAvgSum2", 0);
                PlayerPrefs.SetFloat("AveragesSum2", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
                PlayerPrefs.SetInt("TotalPushups2", 0);
                PlayerPrefs.SetInt("TotalWorkoutsTue", 0);
                PlayerPrefs.SetInt("TotalWorkouts2", 0);
            }

            int today3 = PlayerPrefs.GetInt("WednesdayDay");
            if (today3 != DayNow)
            {
                PlayerPrefs.SetFloat("TotalAvgSum3", 0);
                PlayerPrefs.SetFloat("AveragesSum3", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
                PlayerPrefs.SetInt("TotalPushups3", 0);
                PlayerPrefs.SetInt("TotalWorkoutsWed", 0);
                PlayerPrefs.SetInt("TotalWorkouts3", 0);
                PlayerPrefs.SetInt("WednesdayDay", DayNow);
            }

            int today4 = PlayerPrefs.GetInt("ThursdayDay");
            if (today4 != DayNow - 6)
            {
                PlayerPrefs.SetFloat("TotalAvgSum4", 0);
                PlayerPrefs.SetFloat("AveragesSum4", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
                PlayerPrefs.SetInt("TotalPushups4", 0);
                PlayerPrefs.SetInt("TotalWorkoutsThu", 0);
                PlayerPrefs.SetInt("TotalWorkouts4", 0);
            }

            int today5 = PlayerPrefs.GetInt("FridayDay");
            if (today5 != DayNow - 5)
            {
                PlayerPrefs.SetFloat("TotalAvgSum5", 0);
                PlayerPrefs.SetFloat("AveragesSum5", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
                PlayerPrefs.SetInt("TotalPushups5", 0);
                PlayerPrefs.SetInt("TotalWorkoutsFri", 0);
                PlayerPrefs.SetInt("TotalWorkouts5", 0);
            }

            int today6 = PlayerPrefs.GetInt("SaturdayDay");
            if (today6 != DayNow - 4)
            {
                PlayerPrefs.SetFloat("TotalAvgSum6", 0);
                PlayerPrefs.SetFloat("AveragesSum6", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);
                PlayerPrefs.SetInt("TotalPushups6", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSat", 0);
                PlayerPrefs.SetInt("TotalWorkouts6", 0);
            }

            int today7 = PlayerPrefs.GetInt("SundayDay");
            if (today7 != DayNow - 3)
            {
                PlayerPrefs.SetFloat("TotalAvgSum7", 0);
                PlayerPrefs.SetFloat("AveragesSum7", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
                PlayerPrefs.SetInt("TotalPushups7", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSun", 0);
                PlayerPrefs.SetInt("TotalWorkouts7", 0);
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Thursday)
        {
            int DayNow = System.DateTime.Now.Day;

            int today1 = PlayerPrefs.GetInt("MondayDay");
            if (today1 != DayNow - 3)
            {
                PlayerPrefs.SetFloat("TotalAvgSum1", 0);
                PlayerPrefs.SetFloat("AveragesSum1", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
                PlayerPrefs.SetInt("TotalPushups1", 0);
                PlayerPrefs.SetInt("TotalWorkoutsMon", 0);
                PlayerPrefs.SetInt("TotalWorkouts1", 0);
            }

            int today2 = PlayerPrefs.GetInt("TuesdayDay");
            if (today2 != DayNow - 2)
            {
                PlayerPrefs.SetFloat("TotalAvgSum2", 0);
                PlayerPrefs.SetFloat("AveragesSum2", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
                PlayerPrefs.SetInt("TotalPushups2", 0);
                PlayerPrefs.SetInt("TotalWorkoutsTue", 0);
                PlayerPrefs.SetInt("TotalWorkouts2", 0);
            }

            int today3 = PlayerPrefs.GetInt("WednesdayDay");
            if (today3 != DayNow - 1)
            {
                PlayerPrefs.SetFloat("TotalAvgSum3", 0);
                PlayerPrefs.SetFloat("AveragesSum3", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
                PlayerPrefs.SetInt("TotalPushups3", 0);
                PlayerPrefs.SetInt("TotalWorkoutsWed", 0);
                PlayerPrefs.SetInt("TotalWorkouts3", 0);
            }

            int today4 = PlayerPrefs.GetInt("ThursdayDay");
            if (today4 != DayNow)
            {
                PlayerPrefs.SetFloat("TotalAvgSum4", 0);
                PlayerPrefs.SetFloat("AveragesSum4", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
                PlayerPrefs.SetInt("TotalPushups4", 0);
                PlayerPrefs.SetInt("TotalWorkoutsThu", 0);
                PlayerPrefs.SetInt("TotalWorkouts4", 0);
                PlayerPrefs.SetInt("ThursdayDay", DayNow);
            }

            int today5 = PlayerPrefs.GetInt("FridayDay");
            if (today5 != DayNow - 6)
            {
                PlayerPrefs.SetFloat("TotalAvgSum5", 0);
                PlayerPrefs.SetFloat("AveragesSum5", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
                PlayerPrefs.SetInt("TotalPushups5", 0);
                PlayerPrefs.SetInt("TotalWorkoutsFri", 0);
                PlayerPrefs.SetInt("TotalWorkouts5", 0);
            }

            int today6 = PlayerPrefs.GetInt("SaturdayDay");
            if (today6 != DayNow - 5)
            {
                PlayerPrefs.SetFloat("TotalAvgSum6", 0);
                PlayerPrefs.SetFloat("AveragesSum6", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);
                PlayerPrefs.SetInt("TotalPushups6", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSat", 0);
                PlayerPrefs.SetInt("TotalWorkouts6", 0);
            }

            int today7 = PlayerPrefs.GetInt("SundayDay");
            if (today7 != DayNow - 4)
            {
                PlayerPrefs.SetFloat("TotalAvgSum7", 0);
                PlayerPrefs.SetFloat("AveragesSum7", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
                PlayerPrefs.SetInt("TotalPushups7", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSun", 0);
                PlayerPrefs.SetInt("TotalWorkouts7", 0);
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Friday)
        {
            int DayNow = System.DateTime.Now.Day;

            int today1 = PlayerPrefs.GetInt("MondayDay");
            if (today1 != DayNow - 4)
            {
                PlayerPrefs.SetFloat("TotalAvgSum1", 0);
                PlayerPrefs.SetFloat("AveragesSum1", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
                PlayerPrefs.SetInt("TotalPushups1", 0);
                PlayerPrefs.SetInt("TotalWorkoutsMon", 0);
                PlayerPrefs.SetInt("TotalWorkouts1", 0);
            }

            int today2 = PlayerPrefs.GetInt("TuesdayDay");
            if (today2 != DayNow - 3)
            {
                PlayerPrefs.SetFloat("TotalAvgSum2", 0);
                PlayerPrefs.SetFloat("AveragesSum2", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
                PlayerPrefs.SetInt("TotalPushups2", 0);
                PlayerPrefs.SetInt("TotalWorkoutsTue", 0);
                PlayerPrefs.SetInt("TotalWorkouts2", 0);
            }

            int today3 = PlayerPrefs.GetInt("WednesdayDay");
            if (today3 != DayNow - 2)
            {
                PlayerPrefs.SetFloat("TotalAvgSum3", 0);
                PlayerPrefs.SetFloat("AveragesSum3", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
                PlayerPrefs.SetInt("TotalPushups3", 0);
                PlayerPrefs.SetInt("TotalWorkoutsWed", 0);
                PlayerPrefs.SetInt("TotalWorkouts3", 0);
            }

            int today4 = PlayerPrefs.GetInt("ThursdayDay");
            if (today4 != DayNow - 1)
            {
                PlayerPrefs.SetFloat("TotalAvgSum4", 0);
                PlayerPrefs.SetFloat("AveragesSum4", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
                PlayerPrefs.SetInt("TotalPushups4", 0);
                PlayerPrefs.SetInt("TotalWorkoutsThu", 0);
                PlayerPrefs.SetInt("TotalWorkouts4", 0);
            }

            int today5 = PlayerPrefs.GetInt("FridayDay");
            if (today5 != DayNow)
            {
                PlayerPrefs.SetFloat("TotalAvgSum5", 0);
                PlayerPrefs.SetFloat("AveragesSum5", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
                PlayerPrefs.SetInt("TotalPushups5", 0);
                PlayerPrefs.SetInt("TotalWorkoutsFri", 0);
                PlayerPrefs.SetInt("TotalWorkouts5", 0);
                PlayerPrefs.SetInt("FridayDay", DayNow);
            }

            int today6 = PlayerPrefs.GetInt("SaturdayDay");
            if (today6 != DayNow - 6)
            {
                PlayerPrefs.SetFloat("TotalAvgSum6", 0);
                PlayerPrefs.SetFloat("AveragesSum6", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);
                PlayerPrefs.SetInt("TotalPushups6", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSat", 0);
                PlayerPrefs.SetInt("TotalWorkouts6", 0);
            }

            int today7 = PlayerPrefs.GetInt("SundayDay");
            if (today7 != DayNow - 5)
            {
                PlayerPrefs.SetFloat("TotalAvgSum7", 0);
                PlayerPrefs.SetFloat("AveragesSum7", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
                PlayerPrefs.SetInt("TotalPushups7", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSun", 0);
                PlayerPrefs.SetInt("TotalWorkouts7", 0);
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Saturday)
        {
            int DayNow = System.DateTime.Now.Day;

            int today1 = PlayerPrefs.GetInt("MondayDay");
            if (today1 != DayNow - 5)
            {
                PlayerPrefs.SetFloat("TotalAvgSum1", 0);
                PlayerPrefs.SetFloat("AveragesSum1", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
                PlayerPrefs.SetInt("TotalPushups1", 0);
                PlayerPrefs.SetInt("TotalWorkoutsMon", 0);
                PlayerPrefs.SetInt("TotalWorkouts1", 0);
            }

            int today2 = PlayerPrefs.GetInt("TuesdayDay");
            if (today2 != DayNow - 4)
            {
                PlayerPrefs.SetFloat("TotalAvgSum2", 0);
                PlayerPrefs.SetFloat("AveragesSum2", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
                PlayerPrefs.SetInt("TotalPushups2", 0);
                PlayerPrefs.SetInt("TotalWorkoutsTue", 0);
                PlayerPrefs.SetInt("TotalWorkouts2", 0);
            }

            int today3 = PlayerPrefs.GetInt("WednesdayDay");
            if (today3 != DayNow - 3)
            {
                PlayerPrefs.SetFloat("TotalAvgSum3", 0);
                PlayerPrefs.SetFloat("AveragesSum3", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
                PlayerPrefs.SetInt("TotalPushups3", 0);
                PlayerPrefs.SetInt("TotalWorkoutsWed", 0);
                PlayerPrefs.SetInt("TotalWorkouts3", 0);
            }

            int today4 = PlayerPrefs.GetInt("ThursdayDay");
            if (today4 != DayNow - 2)
            {
                PlayerPrefs.SetFloat("TotalAvgSum4", 0);
                PlayerPrefs.SetFloat("AveragesSum4", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
                PlayerPrefs.SetInt("TotalPushups4", 0);
                PlayerPrefs.SetInt("TotalWorkoutsThu", 0);
                PlayerPrefs.SetInt("TotalWorkouts4", 0);
            }

            int today5 = PlayerPrefs.GetInt("FridayDay");
            if (today5 != DayNow - 1)
            {
                PlayerPrefs.SetFloat("TotalAvgSum5", 0);
                PlayerPrefs.SetFloat("AveragesSum5", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
                PlayerPrefs.SetInt("TotalPushups5", 0);
                PlayerPrefs.SetInt("TotalWorkoutsFri", 0);
                PlayerPrefs.SetInt("TotalWorkouts5", 0);
            }

            int today6 = PlayerPrefs.GetInt("SaturdayDay");
            if (today6 != DayNow)
            {
                PlayerPrefs.SetFloat("TotalAvgSum6", 0);
                PlayerPrefs.SetFloat("AveragesSum6", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);
                PlayerPrefs.SetInt("TotalPushups6", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSat", 0);
                PlayerPrefs.SetInt("TotalWorkouts6", 0);
                PlayerPrefs.SetInt("SaturdayDay", DayNow);
            }

            int today7 = PlayerPrefs.GetInt("SundayDay");
            if (today7 != DayNow - 6)
            {
                PlayerPrefs.SetFloat("TotalAvgSum7", 0);
                PlayerPrefs.SetFloat("AveragesSum7", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
                PlayerPrefs.SetInt("TotalPushups7", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSun", 0);
                PlayerPrefs.SetInt("TotalWorkouts7", 0);
            }
        }

        if (day1.DayOfWeek == DayOfWeek.Sunday)
        {
            int DayNow = System.DateTime.Now.Day;

            int today1 = PlayerPrefs.GetInt("MondayDay");
            if (today1 != DayNow - 6)
            {
                PlayerPrefs.SetFloat("TotalAvgSum1", 0);
                PlayerPrefs.SetFloat("AveragesSum1", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts1", 0);
                PlayerPrefs.SetInt("TotalPushups1", 0);
                PlayerPrefs.SetInt("TotalWorkoutsMon", 0);
                PlayerPrefs.SetInt("TotalWorkouts1", 0);
            }

            int today2 = PlayerPrefs.GetInt("TuesdayDay");
            if (today2 != DayNow - 5)
            {
                PlayerPrefs.SetFloat("TotalAvgSum2", 0);
                PlayerPrefs.SetFloat("AveragesSum2", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts2", 0);
                PlayerPrefs.SetInt("TotalPushups2", 0);
                PlayerPrefs.SetInt("TotalWorkoutsTue", 0);
                PlayerPrefs.SetInt("TotalWorkouts2", 0);
            }

            int today3 = PlayerPrefs.GetInt("WednesdayDay");
            if (today3 != DayNow - 4)
            {
                PlayerPrefs.SetFloat("TotalAvgSum3", 0);
                PlayerPrefs.SetFloat("AveragesSum3", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts3", 0);
                PlayerPrefs.SetInt("TotalPushups3", 0);
                PlayerPrefs.SetInt("TotalWorkoutsWed", 0);
                PlayerPrefs.SetInt("TotalWorkouts3", 0);
            }

            int today4 = PlayerPrefs.GetInt("ThursdayDay");
            if (today4 != DayNow - 3)
            {
                PlayerPrefs.SetFloat("TotalAvgSum4", 0);
                PlayerPrefs.SetFloat("AveragesSum4", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts4", 0);
                PlayerPrefs.SetInt("TotalPushups4", 0);
                PlayerPrefs.SetInt("TotalWorkoutsThu", 0);
                PlayerPrefs.SetInt("TotalWorkouts4", 0);
            }

            int today5 = PlayerPrefs.GetInt("FridayDay");
            if (today5 != DayNow - 2)
            {
                PlayerPrefs.SetFloat("TotalAvgSum5", 0);
                PlayerPrefs.SetFloat("AveragesSum5", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts5", 0);
                PlayerPrefs.SetInt("TotalPushups5", 0);
                PlayerPrefs.SetInt("TotalWorkoutsFri", 0);
                PlayerPrefs.SetInt("TotalWorkouts5", 0);
            }

            int today6 = PlayerPrefs.GetInt("SaturdayDay");
            if (today6 != DayNow - 1)
            {
                PlayerPrefs.SetFloat("TotalAvgSum6", 0);
                PlayerPrefs.SetFloat("AveragesSum6", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts6", 0);
                PlayerPrefs.SetInt("TotalPushups6", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSat", 0);
                PlayerPrefs.SetInt("TotalWorkouts6", 0);
            }

            int today7 = PlayerPrefs.GetInt("SundayDay");
            if (today7 != DayNow)
            {
                PlayerPrefs.SetFloat("TotalAvgSum7", 0);
                PlayerPrefs.SetFloat("AveragesSum7", 0);
                PlayerPrefs.SetInt("TotalAvgPaceWorkouts7", 0);
                PlayerPrefs.SetInt("TotalPushups7", 0);
                PlayerPrefs.SetInt("TotalWorkoutsSun", 0);
                PlayerPrefs.SetInt("TotalWorkouts7", 0);
                PlayerPrefs.SetInt("SundayDay", DayNow);
            }
        }

        int status;
        status = PlayerPrefs.GetInt("LogOut");
        if (status == 10)
        {
            if (PlayerPrefs.GetInt("Theme") == 1)
            {
                logInBadgesText.SetActive(true);
                logInBadgesText1.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Theme") == 0)
            {
                logInBadgesText.SetActive(false);
                logInBadgesText1.SetActive(true);
            }
            loginText.text = "Login/Register";
            loginText1.text = "Login/Register";
            badgesButtonLoggedIn.SetActive(false);
            badgesButtonLoggedOut.SetActive(true);
            badgesButtonLoggedIn1.SetActive(false);
            badgesButtonLoggedOut1.SetActive(true);
        }
        if (status == 1)
        {
            logInBadgesText.SetActive(false);
            loginText.text = "Data/Scoreboard";
            logInBadgesText1.SetActive(false);
            loginText1.text = "Data/Scoreboard";
            badgesButtonLoggedIn.SetActive(true);
            badgesButtonLoggedOut.SetActive(false);
            badgesButtonLoggedIn1.SetActive(true);
            badgesButtonLoggedOut1.SetActive(false);
        }
    }

    public void DarkModeButton()
    {
        PlayerPrefs.SetInt("Theme", 0);
        pushupScroll.GetComponent<Image>().color = new Color(0.3207547f, 0.29861f, 0.2859558f, 1f);
        paceScroll.GetComponent<Image>().color = new Color(0.3207547f, 0.29861f, 0.2859558f, 1f);
        workoutsScroll.GetComponent<Image>().color = new Color(0.3207547f, 0.29861f, 0.2859558f, 1f);
        pushupsAchievmentsText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        paceAchievmentsText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        workoutsAchievmentsText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        currentRecordText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        currentRecordText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        //currentPushupRecordText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        //currentPaceRecordText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        //currentWorkoutRecordText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        //currentPushupRecordText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        //currentPaceRecordText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        //currentWorkoutRecordText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        dailyText1.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        dailyText2.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        dailyText3.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        dailyText4.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        dailyText5.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        dailyText6.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        dailyText7.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        DateText.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        loginTextTheme.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        registerTextTheme.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        userDataTextTheme.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
        scoreboardTextTheme.color = new Color(0.8313726f, 0.7803922f, 0.05882353f, 1f);
    }

    public void LightModeButton()
    {
        PlayerPrefs.SetInt("Theme", 1);
        pushupScroll.GetComponent<Image>().color = new Color(1f, 0.5137255f, 0.1568628f, 1f);
        paceScroll.GetComponent<Image>().color = new Color(0.4392157f, 0.5137255f, 0.7921569f, 1f);
        workoutsScroll.GetComponent<Image>().color = new Color(1f, 0.8000001f, 0.2509804f, 1f);
        pushupsAchievmentsText.color = new Color(0.9843138f, 0.4196079f, 0.2627451f, 1f);
        paceAchievmentsText.color = new Color(0.3882353f, 0.5372549f, 0.8078432f, 1f);
        workoutsAchievmentsText.color = new Color(0.9490197f, 0.8235295f, 0.3098039f, 1f);
        currentRecordText.color = new Color(1f, 1f, 1f, 1f);
        currentRecordText1.color = new Color(1f, 1f, 1f, 1f);
        //currentPushupRecordText.color = new Color(1f, 1f, 1f, 1f);
        //currentPaceRecordText.color = new Color(1f, 1f, 1f, 1f);
        //currentWorkoutRecordText.color = new Color(1f, 1f, 1f, 1f);
        //currentPushupRecordText1.color = new Color(1f, 1f, 1f, 1f);
        //currentPaceRecordText1.color = new Color(1f, 1f, 1f, 1f);
        //currentWorkoutRecordText1.color = new Color(1f, 1f, 1f, 1f);
        dailyText1.color = new Color(1f, 1f, 1f, 1f);
        dailyText2.color = new Color(1f, 1f, 1f, 1f);
        dailyText3.color = new Color(1f, 1f, 1f, 1f);
        dailyText4.color = new Color(1f, 1f, 1f, 1f);
        dailyText5.color = new Color(1f, 1f, 1f, 1f);
        dailyText6.color = new Color(1f, 1f, 1f, 1f);
        dailyText7.color = new Color(1f, 1f, 1f, 1f);
        DateText.color = new Color(0.1960784f, 0.1960784f, 0.1960784f, 1f);
        loginTextTheme.color = new Color(1f, 1f, 1f, 1f);
        registerTextTheme.color = new Color(1f, 1f, 1f, 1f);
        userDataTextTheme.color = new Color(1f, 1f, 1f, 1f);
        scoreboardTextTheme.color = new Color(1f, 1f, 1f, 1f);
    }

    public void EffectButton()
    {
        int effects;
        effects = 10;
        PlayerPrefs.SetInt("Effect", effects);
    }

    public void EffectButton1()
    {
        int effects;
        effects = 1;
        PlayerPrefs.SetInt("Effect", effects);
    }

    public void MusicButton()
    {
        int muzici;
        muzici = 10;
        PlayerPrefs.SetInt("Music", muzici);
    }

    public void MusicButton1()
    {
        int muzici;
        muzici = 1;
        PlayerPrefs.SetInt("Music", muzici);
    }

    public void LogOutPush()
    {
        ok = 10;
        PlayerPrefs.SetInt("LogOut", ok);
    }
}
