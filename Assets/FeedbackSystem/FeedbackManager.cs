using System.Collections.Generic;
using UnityEngine;

public class FeedbackManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> yanlis;
    [SerializeField] private List<GameObject> dogruV1;
    [SerializeField] private List<GameObject> dogruV2;
    [SerializeField] private List<GameObject> dogruV3;
    [SerializeField] private List<GameObject> dogruV4;


    private void PlayFeedback(List<GameObject> feedbackList)
    {
        StopAllFeedbacks();
        feedbackList.ForEach(go => { if (go != null) go.SetActive(true); });
    }

    private void StopAllFeedbacks()
    {
        // Alt alta hızlı çözüm
        yanlis.ForEach(go => { if (go != null) go.SetActive(false); });
        dogruV1.ForEach(go => { if (go != null) go.SetActive(false); });
        dogruV2.ForEach(go => { if (go != null) go.SetActive(false); });
        dogruV3.ForEach(go => { if (go != null) go.SetActive(false); });
        dogruV4.ForEach(go => { if (go != null) go.SetActive(false); });
    }

    // --- Play Metodları ---

    public void PlayYanlis() => PlayFeedback(yanlis);
    public void PlayDogruV1() => PlayFeedback(dogruV1);
    public void PlayDogruV2() => PlayFeedback(dogruV2);
    public void PlayDogruV3() => PlayFeedback(dogruV3);
    public void PlayDogruV4() => PlayFeedback(dogruV4);
}