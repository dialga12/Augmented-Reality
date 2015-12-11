using UnityEngine;
using System.Collections;

public class variableGlobalInformacion : MonoBehaviour 
{
	public bool informacionActiva;
	
	// Use this for initialization
	void Start () 
	{
		informacionActiva = true;
	}

	public void Activar ()
	{
		informacionActiva = true;
	}

	public void Desactivar ()
	{
		informacionActiva = false;
	}

	public bool GetInformacion ()
	{
		return informacionActiva;
	}
}