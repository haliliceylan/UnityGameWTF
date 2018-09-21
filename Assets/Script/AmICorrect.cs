using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmICorrect : MonoBehaviour {

	private CorrectWardrobeController correctWardrobeController;
	// Use this for initialization
	void Start () {
		correctWardrobeController = transform.GetComponentInParent<CorrectWardrobeController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	bool isThisCorrect(){
		return gameObject == correctWardrobeController.getCorrectWardrobe();
	}
}
