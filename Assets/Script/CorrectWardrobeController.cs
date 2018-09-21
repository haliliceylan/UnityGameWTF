using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectWardrobeController : MonoBehaviour {
	public Light CorrectLight;

	private int TotalWardrobeCount;
	private int CorrectWardrobe;

	void Start () {
		TotalWardrobeCount = transform.childCount;
		selectNewCorrectWardrobe ();
	}

	void Update () {
		
	}

	public void selectNewCorrectWardrobe(){
		CorrectWardrobe = Random.Range(0, TotalWardrobeCount-1);
		CorrectLight.transform.position = getCorrectWardrobe().transform.position;
		CorrectLight.transform.localPosition += new Vector3 (-0.2f, 0.0f, -0.2f);
		CorrectLight.enabled = false;
		Debug.Log(getCorrectWardrobe ().GetComponent<Animator> ());
	}

	public GameObject getCorrectWardrobe(){
		return transform.GetChild(CorrectWardrobe).gameObject;
	}

	public bool isCorrectWardrobe(GameObject gameObject){
		return (getCorrectWardrobe () == gameObject);
	}

}
