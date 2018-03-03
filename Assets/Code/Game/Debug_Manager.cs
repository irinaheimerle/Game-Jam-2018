using UnityEngine;
using System.Collections;

public class Debug_Manager : MonoBehaviour
{
	private static Debug_Manager _instance;
	private static bool _showDebugTools = true;

	//TODO: Remove after testing.
	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(Screen.width - 130, 0, 130, 40));
		if (GUILayout.Button("Toggle Debug Tools"))
			_showDebugTools = !_showDebugTools;
		GUILayout.EndArea();

		//Debug.Log("TOOLS: " + _showDebugTools);
	}


	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/
	public static bool ShowDebugTools { get { return _showDebugTools; } }
}
