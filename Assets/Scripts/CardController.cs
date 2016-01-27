using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {
	Vector3 dist;
	float posX;
	float posY;

	// Use this for initialization
	void Start () {
		dist = Camera.main.WorldToScreenPoint (transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
	}
	
	// Update is called once per frame
	void Update () {
		float left = Input.GetAxis ("Horizontal");
		float top = Input.GetAxis ("Vertical");
		transform.Rotate (new Vector3 (left, 0, top));
	}

	void OnMouseDrag(){
		Vector3 curPos = new Vector3 (Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
		Vector3 worldPos = Camera.main.ScreenToWorldPoint (curPos);
		transform.position = worldPos;
	}
}
