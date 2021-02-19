using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour , IUnityAdsListener
{
#if UNITY_IOS
    private string gameID = "34567";
#elif  UNITY_ANDROID 
    private string gameID = "12345";
#elif UNITY_EDITOR
    private string gameID = "111111"; //GameId goes in here.
#endif 

    private string placementId = "clickReward";
    public static AdManager instance;

    void Awake()
    {
        instance = this;
    }
    public void PlayAdForClicks()
    {
        Advertisement.Show(placementId);
    }
    public void OnUnityAdsDidError(string message)
    {
        
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            GameManager.instance.AddClicks(300);
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        
    }

    public void OnUnityAdsReady(string placementId)
    {
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show("banner");
    }

    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameID, true); 
    }
}
