using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public GameObject countDown;
    public AudioSource getReady;
    public AudioSource Go;
    public AudioSource LevelMusic;

    public GameObject LapTimer;
    public GameObject CarControls;
    public GameObject AiCarControls; 

	void Start () {
        StartCoroutine(CountStart());
	}

    IEnumerator CountStart()
    {
        // 3
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<Text>().text = "3";
        getReady.Play();
        countDown.SetActive(true);

        // 2
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "2";
        getReady.Play();
        countDown.SetActive(true);

        // 1
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "1";
        getReady.Play();
        countDown.SetActive(true);

        // Go!
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "Go!";
        Go.Play();
        LevelMusic.Play();
        countDown.SetActive(true);

        LapTimer.SetActive(true);
        CarControls.SetActive(true);
        AiCarControls.SetActive(true);
    }

}
