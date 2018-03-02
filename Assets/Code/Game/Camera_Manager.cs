using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Manages Camera movement.
/// </summary>
public class Camera_Manager : MonoBehaviour
{
	private static Camera_Manager _instance;
	public Camera cam;

	// Use this for initialization
	void Awake()
	{
		_instance = this;
	}
	

	// Update is called once per frame
	void Update()
	{

	}


	//TODO: Remove once done testing.
	private void OnGUI()
	{
		if (!Debug_Manager.ShowDebugTools) return;

		GUILayout.BeginArea(new Rect(0, 200, 200, 200));
		if (GUILayout.Button("Shake Cam"))
			StartCoroutine(ShakeCamera(1.0f, 0.4f));
		GUILayout.EndArea();
	}


	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	public static IEnumerator ShakeCamera(float duration, float magnitude)
	{
        yield break;
		float currDuration = 0f;

		while(currDuration < duration && Game_Manager.CurrentState == Game_Manager.State.Play)
		{
			float x = UnityEngine.Random.Range(-1.0f, 1.0f) * magnitude;
			float y = UnityEngine.Random.Range(-1.0f, 1.0f) * magnitude;

			_instance.cam.transform.localPosition = new Vector3(x, y, _instance.cam.transform.localPosition.z);

			currDuration += Time.deltaTime;

			yield return null;
		}

		
	}
	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/


}
