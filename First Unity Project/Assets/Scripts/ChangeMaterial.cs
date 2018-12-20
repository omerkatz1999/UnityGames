using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {


    public Material[] material;

    Renderer rend;

    // Use this for initialization
	void Start () {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
	}
	
	
	public void PhaseModeMaterial () {

        rend.sharedMaterial = material[1];
        Invoke("NormalModeMaterial", 2.8f);

    }

    void NormalModeMaterial()
    {

        rend.sharedMaterial = material[0];

    }
}
