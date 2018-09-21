using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectWardrobeController : MonoBehaviour {

	private int TotalWardrobeCount;
	private int CorrectWardrobe;
	// Use this for initialization
	void Start () {
		TotalWardrobeCount = transform.childCount;
	}

	void Update () {
		
	}

	public void selectNewCorrectWardrobe(){
		CorrectWardrobe = Random.Range(0, TotalWardrobeCount-1);
	}

	public GameObject getCorrectWardrobe(){
		return transform.GetChild(CorrectWardrobe).gameObject;
	}
}
