using UnityEngine;
using System.Collections;

public class Imagenes : MonoBehaviour
{
    public int cont;
    public GameObject [] imagenes;

	// Use this for initialization
    void Start()
	{
		cont = 0;
        imagenes = GameObject.FindGameObjectsWithTag("Imagen");
	}

	void OnMouseUp()
	{
		// this object was clicked - do something
		if (cont % 2 == 0) 
		{
			foreach (GameObject imagen in imagenes) 
			{
				imagen.SetActive (false);
			}
			cont++;
		}
		else 
		{
			foreach (GameObject imagen in imagenes) 
			{
				imagen.SetActive (true);
			}
			cont++;
	    }
	}
}