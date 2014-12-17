using UnityEngine;
using System.Collections;

public class fadeCamera : MonoBehaviour {
	public float fadeSpeed = 0.00000001f;   

	void Awake ()
	{
		// Set the texture so that it is the the size of the screen and covers it.
		//guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
		guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);	}
}
