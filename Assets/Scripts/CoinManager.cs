using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour {

	public GameObject door;



	void Start () {
		
	}
	
	void Update () {
		if (transform.childCount == 0) {
			Destroy(door);
			Destroy(gameObject);
		}
	}
}
