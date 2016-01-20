using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Analytics;

public class main : MonoBehaviour {

	private string FLURRY_API_ANDROID = "S6NRW2DT77XG428PTD4V";
	private string FLURRY_API_IOS = "KRMJY5F2GPXXTBN65FR9";

	void Start () {
		GameObject.Find("FlurryObject").GetComponent<Flurry>().StartSession(FLURRY_API_IOS, FLURRY_API_ANDROID);
		GameObject.Find("FlurryObject").GetComponent<Flurry>().SetLogLevel(LogLevel.Debug);
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.frameCount % 200 == 0 || Time.frameCount < 2) {

			// example for single log event
			Debug.Log (GameObject.Find("FlurryObject").GetComponent<Flurry>().LogEvent("test new update"));

			// example for log event with parameters
			Dictionary<string, string> parameters = new Dictionary<string, string>();
			parameters.Add("key", "value");
			Debug.Log (GameObject.Find("FlurryObject").GetComponent<Flurry>().LogEvent("test with parameters", parameters));

//			Debug.Log ("logEvent test update");
		}
	}
	
	void OnDestroy(){

	}

}
