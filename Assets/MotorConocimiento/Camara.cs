using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseDown(){
		// this object was clicked - do something
		Application.LoadLevel("PrimeraEscena");
	}
		
	// Update is called once per frame
	void Update () {
	
	}
}
