using UnityEngine;
using System.Collections;

public class Screen : MonoBehaviour {

	void Start () {
		WebCamDevice[] devices = WebCamTexture.devices;
		if (devices.Length > 0) {
			var webcamTexture = new WebCamTexture(devices[0].name ,320, 240, 10);
			renderer.material.mainTexture = webcamTexture;
			webcamTexture.Play();
		}
	}
	
	void Update () {
	}
}
