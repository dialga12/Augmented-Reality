using UnityEngine;
using System.Collections;
using Vuforia;

public class ReproducirAudio : MonoBehaviour, ITrackableEventHandler 
{
	private TrackableBehaviour manejadorTrackableBehaviour;
	public AudioSource modeloAudio;
	public GameObject audioActivo;

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
			if (audioActivo.GetComponent<variableGlobalAudio> ().GetAudio () == true) 
			{
				modeloAudio.Play ();
			}
		}
		else 
		{
			modeloAudio.Pause ();
		}
	}
}