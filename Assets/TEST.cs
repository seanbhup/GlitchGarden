using UnityEngine;
using System.Collections;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print (PlayerPrefsManager.GetMasterVolume());
		print (PlayerPrefsManager.SetMasterVolume(0.3f));
		print (PlayerPrefsManager.GetMasterVolume());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
