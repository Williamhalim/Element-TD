using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Fadeout());
	}
		
	IEnumerator Fadeout(){
		yield return new WaitForSeconds (4);
		Destroy (gameObject);
	}
}
