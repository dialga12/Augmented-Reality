using UnityEngine;
using System.Collections;
using System.Threading;

public class TomarFoto : MonoBehaviour 
{
	void OnMouseUp() 
	{	
		GameObject [] imagenes;
		imagenes = GameObject.FindGameObjectsWithTag("Imagen");

		foreach (GameObject imagen in imagenes) 
		{
			imagen.SetActive (false);
		}


		
		//Thread.Sleep(2000);
		string datacion = System.DateTime.Now.ToFileTime().ToString();
		Application.CaptureScreenshot(datacion + ".png");



		foreach (GameObject imagen in imagenes) 
		{
			imagen.SetActive (true);
		}
	}
}


