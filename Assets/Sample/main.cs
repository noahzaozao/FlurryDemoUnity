using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {
#if UNITY_ANDROID
	private string FLURRY_API = "S6NRW2DT77XG428PTD4V";
#elif UNITY_IPHONE
	private string FLURRY_API = "KRMJY5F2GPXXTBN65FR9";
#else
	private string FLURRY_API = "x";
#endif
	// Use this for initialization
	void Start () {
		FlurryAgent.Instance.onStartSession(FLURRY_API);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.frameCount % 200 == 0 || Time.frameCount < 2) {
			FlurryAgent.Instance.logEvent ("test update");
			Debug.Log ("logEvent test update");
		}
	}
	
	void OnDestroy(){
		FlurryAgent.Instance.onEndSession();
	}
}
