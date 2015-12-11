using UnityEngine;
using System.Collections;

public class Salir : MonoBehaviour 
{
	void OnMouseDown()
	{
		// this object was clicked - do something
		Application.Quit();
	}
}