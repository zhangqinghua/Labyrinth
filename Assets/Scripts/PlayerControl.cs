using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	private Rigidbody rigidbody;

	// 碰撞效果
	public GameObject HitPre;
	// 爆炸效果
	public GameObject BombPre;

	// 血量
	public int hp = 3;

	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	void Update () {
		// 水平轴
		float horizontal = Input.GetAxis("Horizontal");
		// 垂直轴
		float vertical = Input.GetAxis("Vertical");

		Vector3 dir = new Vector3(horizontal, 0, vertical);
		if (dir != Vector3.zero) {
			// 移动
			rigidbody.velocity = dir * 2;
		}
	}

	// 只要碰到碰撞体就会调用
	void OnCollisionEnter(Collision collision) {
		// 如果碰到的是墙，减血
		if (collision.collider.tag == "Wall") {
			hp --;
			if (hp <=0) {
				// 死掉
				Instantiate(BombPre, transform.position, transform.rotation);
				Destroy(gameObject);
			} else {
				Instantiate(HitPre, collision.contacts[0].point, Quaternion.identity);
			}
		}
	}
}
