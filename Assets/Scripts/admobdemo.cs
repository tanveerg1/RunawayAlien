using UnityEngine;
using System.Collections;
using admob;
public class admobdemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("start unity demo-------------");
         initAdmob();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    Admob ad;
    //bool isAdmobInited = false;
    void initAdmob()
    {
        
          //  isAdmobInited = true;
             ad = Admob.Instance();
            ad.bannerEventHandler += onBannerEvent;
            ad.interstitialEventHandler += onInterstitialEvent;
			ad.initAdmob("ca-app-pub-6716455894332168/4566809133", "ca-app-pub-6716455894332168/7461399935");
        //   ad.setTesting(true);
            ad.setGender(AdmobGender.MALE);
            string[] keywords = { "game","crash","male game"};
            ad.setKeywords(keywords);
            Debug.Log("admob inited -------------");
        
    }
	void OnGUI(){
        if (GUI.Button(new Rect(120, 0, 100, 60), "showInterstitial"))
        {
          
            if (ad.isInterstitialReady())
            {
                ad.showInterstitial();
            }
            else
            {
                ad.loadInterstitial();
            }
        }
        
        if (GUI.Button(new Rect(0, 100, 100, 60), "showbanner"))
        {
            Admob.Instance().showBannerRelative(AdSize.SmartBanner, AdPosition.BOTTOM_CENTER, 0);
        }
        if (GUI.Button(new Rect(120, 100, 100, 60), "showbannerABS"))
        {
            Admob.Instance().showBannerAbsolute(AdSize.Banner, 0, 300);
        }
        if (GUI.Button(new Rect(240, 100, 100, 60), "removebanner"))
        {
            Admob.Instance().removeBanner();
        }
       
        
	}
    void onInterstitialEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobEvent---" + eventName + "   " + msg);
        if (eventName == AdmobEvent.onAdLoaded)
        {
            Admob.Instance().showInterstitial();
        }
    }
    void onBannerEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobBannerEvent---" + eventName + "   " + msg);
    }
    void onRewardedVideoEvent(string eventName, string msg)
    {
        Debug.Log("handler onRewardedVideoEvent---" + eventName + "   " + msg);
    }
    void onNativeBannerEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobNativeBannerEvent---" + eventName + "   " + msg);
    }
}
