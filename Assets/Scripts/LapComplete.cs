using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapComplete : MonoBehaviour {

    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;

    public GameObject LapCounter;
    public int lapsDone = 0;
    public int lapsNumber;

    public GameObject bestMin;
    public GameObject bestSec;
    public GameObject bestMilisec;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Player")
        {
            lapsDone++;
            int bestRecord = (int)float.Parse(bestMilisec.GetComponent<Text>().text)
                + (int.Parse(bestSec.GetComponent<Text>().text.Split('.')[0]) * 10)
                + (int.Parse(bestMin.GetComponent<Text>().text.Split(':')[0]) * 60);

            if (bestRecord > LapTimeManager.actualRecord)
            {
                bestMilisec.GetComponent<Text>().text = LapTimeManager.milisecCount.ToString();
                bestSec.GetComponent<Text>().text = LapTimeManager.secCount.ToString("00") + '.';
                bestMin.GetComponent<Text>().text = LapTimeManager.minCount.ToString("00") + ':';

                SaveDB(LapTimeManager.actualRecord);
            }

            ResetLapTime();

            if (lapsDone >= lapsNumber)
            {
                RaceEnding();
                return;
            }

            lapCompleteTrig.SetActive(false);
            halfLapTrig.SetActive(true);
        }
    }

    private void SaveDB(float milisec)
    {
        PlayerPrefs.SetFloat("BestLap01Score", milisec);
    }

    private void ResetLapTime()
    {
        LapTimeManager.milisecCount = 0;
        LapTimeManager.secCount = 0;
        LapTimeManager.minCount = 0;
        LapTimeManager.actualRecord = 0f;

        LapCounter.GetComponent<Text>().text = lapsDone.ToString();
    }

    private void RaceEnding()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
