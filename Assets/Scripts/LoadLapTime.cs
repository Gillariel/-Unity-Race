using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLapTime : MonoBehaviour {

	void Start () {

        if (PlayerPrefs.HasKey("BestLap01Score"))
        {
            float bestRecord = PlayerPrefs.GetFloat("BestLap01Score");
            LapTimeManager.actualRecord = bestRecord;
        }
	}
	
}
