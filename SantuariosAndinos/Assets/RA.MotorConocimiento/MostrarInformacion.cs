using UnityEngine;
using System.Collections;
using Vuforia;

public class MostrarInformacion : MonoBehaviour, ITrackableEventHandler
{
	private TrackableBehaviour manejadorTrackableBehaviour;
	public GameObject informacion;
	public GameObject informacionActiva;

	// Use this for initialization
	void Start () 
	{
		manejadorTrackableBehaviour = GetComponent<TrackableBehaviour> ();
		if (manejadorTrackableBehaviour) 
		{
			manejadorTrackableBehaviour.RegisterTrackableEventHandler(this);
		}	
	}
	
	public void OnTrackableStateChanged(TrackableBehaviour.Status anteriorEstado, 
	                                    TrackableBehaviour.Status nuevoEstado)
	{
		if (nuevoEstado == TrackableBehaviour.Status.DETECTED ||
			nuevoEstado == TrackableBehaviour.Status.TRACKED ||
			nuevoEstado == TrackableBehaviour.Status.EXTENDED_TRACKED) 
		{
			if (informacionActiva.GetComponent<variableGlobalInformacion> ().GetInformacion () == true) 
			{
				informacion.SetActive (true);
			}
		}
		else 
		{
			informacion.SetActive(false);
			//informacionActiva.GetComponent<variableGlobalInformacion>().Desactivar();
		}
	}
}