using UnityEngine;
using System.Collections;

public class Informacion : MonoBehaviour 
{
	public int cont;
	public GameObject informacion;
	public GameObject informacionActiva;

    // Use this for initialization
    void Start()
    {
        cont = 0;
        //informacion = GameObject.FindGameObjectWithTag("fondoTexto");
    }

    void OnMouseUp()
    {
        // this object was clicked - do something
        if (cont % 2 == 0)
		{
			informacion.SetActive (false);
			informacionActiva.GetComponent<variableGlobalInformacion>().Desactivar();
            cont++;
        }
        else
		{
			informacion.SetActive (true);
			informacionActiva.GetComponent<variableGlobalInformacion>().Activar();
            cont++;
        }
    }
}