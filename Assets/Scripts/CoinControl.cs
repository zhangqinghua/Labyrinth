using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour {


	void Start () {
		
	}
	
	void Update () {
		transform.Rotate(Vector3.forward * 90 * Time.deltaTime);
	}

	// 触发调用
	void OnTriggerEnter(Collider collider) {
		if (collider.tag == "Player") {
			Destroy(gameObject);
		}
	}
}
