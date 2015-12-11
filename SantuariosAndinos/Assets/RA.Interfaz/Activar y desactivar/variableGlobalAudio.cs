using UnityEngine;
using System.Collections;

public class variableGlobalAudio : MonoBehaviour 
{
	public bool audioActivo;
	
	// Use this for initialization
	void Start () 
	{
		audioActivo = true;
	}
	
	public void Activar ()
	{
		audioActivo = true;
	}
	
	public void Desactivar ()
	{
		audioActivo = false;
	}
	
	public bool GetAudio ()
	{
		return audioActivo;
	}
}
