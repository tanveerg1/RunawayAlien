using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class AdMob : MonoBehaviour {
	Admob ad;
	// Use this for initialization
	void Start () {
		ad = Admob.Instance ();
		ad.initAdmob("ca-app-pub-6716455894332168/4566809133", "ca-app-pub-6716455894332168/7461399935");

		ad.showBannerRelative (AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
		if(ad.isInterstitialReady()){
			ad.showInterstitial ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
