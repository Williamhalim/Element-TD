using UnityEngine;
using System.Collections;

public class Blackhole : MonoBehaviour
{
	public float suctionForce = 10.0f;
	public float duration = 2f;

	private bool isActive;
	private float timer;

	private void OnTriggerStay(Collider other){
		StartCoroutine (Fadeout());
		isActive = true;
		// Todo: "tornado" bullet has no rigidbody, this will give a minor error
		Rigidbody rb = other.attachedRigidbody;
		Enemy en = other.GetComponent<Enemy> ();
		en.speed = 0f;

		// Only apply force to objects with a Rigidbody component
		if (rb != null && isActive) {
			Vector2 forceDir = transform.position - other.transform.position;
			rb.AddForce (forceDir.normalized * suctionForce * Time.deltaTime);
		}
	}

	IEnumerator Fadeout(){
		yield return new WaitForSeconds (3);
		Destroy (gameObject);
	}
}