using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Click_Handler : MonoBehaviour {
	public delegate void Click_Event ();
	public Click_Event OnClicked;

	public Material mouseOverMaterial;
	private Material _mainMaterial;

	private Renderer _renderer;

	private void Awake()
	{
		_mainMaterial = GetComponent<Renderer> ().sharedMaterial;

		_renderer = GetComponent<Renderer> ();
	}


	private void OnMouseOver()
	{
		if(mouseOverMaterial != null)
			_renderer.material = mouseOverMaterial;
	}
	private void OnMouseExit()
	{
		if (mouseOverMaterial != null)
			_renderer.material = _mainMaterial;
	}

	private void OnMouseDown()
	{
		if (OnClicked != null)
			OnClicked ();
	}


	/*--------------------------------------------------------------------------------METHODS-----------------------*/
	/*--------------------------------------------------------------------------------ABSTRACTS---------------------*/
	/*--------------------------------------------------------------------------------EVENTS------------------------*/
	/*--------------------------------------------------------------------------------OVERRIDES---------------------*/
	/*--------------------------------------------------------------------------------GETTERS and SETTERS-----------*/


}
