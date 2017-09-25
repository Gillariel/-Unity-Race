using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public List<GameObject> Cameras;
    public int CamMode = 0;

	// Update is called once per frame
	void Update () {

        // Only if button is pressed
		if(Input.GetButtonDown("View Mode"))
            StartCoroutine(ChangeView());
	}

    private IEnumerator ChangeView()
    {
        yield return new WaitForSeconds(0.01f);

        //disable actual cam
        Cameras[CamMode].SetActive(false);
        CamMode = (CamMode == Cameras.Count - 1) ? 0 : CamMode + 1;

        //Activate new one
        Cameras[CamMode].SetActive(true);
    }
}
