using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour {

    private bool isColllided;

	// Use this for initialization
	void Start () {
        isColllided = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ColWithAnithing()
    {
        isColllided = true;
    }
}
