using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiWayPointTracking : MonoBehaviour {

    public GameObject Tracker;
    public List<GameObject> WayPoints;
    public int ActualTrackIndex;
	
	void Update () {
        foreach (GameObject wayPoint in WayPoints)
            if (WayPoints.IndexOf(wayPoint) == ActualTrackIndex)
            {
                //Debug.Log(wayPoint);
                Tracker.transform.position = wayPoint.transform.position;
                return;
            }
            
	}

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "AICar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            ActualTrackIndex += 1;
            /*if (ActualTrackIndex >= WayPoints.Count - 1)
                ActualTrackIndex = 0;*/
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
