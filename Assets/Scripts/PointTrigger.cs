using UnityEngine;

public class PointTrigger : MonoBehaviour {

    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;

    void OnTriggerEnter()
    {
        lapCompleteTrig.SetActive(true);
        halfLapTrig.SetActive(false);
    }
}
