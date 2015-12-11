using UnityEngine;
using System.Collections;

public class Regresar : MonoBehaviour 
{
	void OnMouseDown()
	{
		// this object was clicked - do something
		Application.LoadLevel("Interfaz");
	}
}