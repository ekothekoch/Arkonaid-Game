using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour {

	public GameObject brickParticle;

	void OnCollisionEnter(Collision other)
	{
		Instantiate(brickParticle, transform.position, Quaternion.identity);
		GM.instance.DestroyBrick();
		Destroy(gameObject);
	}
}