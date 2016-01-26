using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float left = Input.GetAxis ("Horizontal");
		float top = Input.GetAxis ("Vertical");
		transform.Rotate (new Vector3 (left, 0, top));
	}
}
