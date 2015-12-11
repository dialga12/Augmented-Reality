using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour 
{
	public int cont;
	public AudioSource modeloAudio;
	public GameObject audioActivo;
	
	// Use this for initialization
	void Start()
	{
		cont = 1;
	}
	
	void OnMouseUp()
	{
		// this object was clicked - do something
		if (cont % 2 == 0)
		{
			modeloAudio.Play();
			audioActivo.GetComponent<variableGlobalAudio>().Activar();
			cont++;
		}
		else
		{
			modeloAudio.Stop();
			audioActivo.GetComponent<variableGlobalAudio>().Desactivar();
			cont++;
		}
	}
}
