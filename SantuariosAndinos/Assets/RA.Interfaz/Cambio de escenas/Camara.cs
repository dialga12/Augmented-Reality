using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour 
{	
	void OnMouseDown()
	{
		// this object was clicked - do something
		Application.LoadLevel("PrimeraEscena");
	}
}