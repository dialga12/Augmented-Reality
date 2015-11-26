using UnityEngine;
using System.Collections;

public class Imagenes : MonoBehaviour {

	// Use this for initialization
	void Start () {	
		cont = 0;
		imagenes = GameObject.FindGameObjectWithTag("Imagenes");
	}
	public int cont;
	public GameObject imagenes;

	void OnMouseDown(){
		// this object was clicked - do something
		if (cont % 2 == 0) {
			imagenes.SetActive (false);
			cont++;
		}
		else {
			imagenes.SetActive (true);
		cont++;
	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
