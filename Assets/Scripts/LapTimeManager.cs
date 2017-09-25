using System;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

    public static int minCount;
    public static int secCount;
    public static float milisecCount;
    public static string miliDisplay;
    public static float actualRecord;

    public GameObject minBox;
    public GameObject secBox;
    public GameObject milisecBox;

    void Update () {
        float elapsedTime = Time.deltaTime * 10;
        actualRecord += elapsedTime;
        milisecCount += elapsedTime;

        miliDisplay = milisecCount.ToString("0");
        milisecBox.GetComponent<Text>().text = miliDisplay;

        if(milisecCount >= 10)
        {
            milisecCount = 0;
            secCount++;
        }

        if(secCount >= 60)
        {
            secCount = 0;
            minCount++;
        }

        secBox.GetComponent<Text>().text = secCount.ToString("00") + ".";
        minBox.GetComponent<Text>().text = minCount.ToString("00") + ":";
    }
}
