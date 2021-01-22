using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	
	public Vector3 target;
	public float bulletSpeed = 0.1f;
	Vector3 speedToTarget;

    // Start is called before the first frame update
    void Start()
    {
        speedToTarget = SpeedToTarget(target);
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 position = this.transform.position;
		transform.position = new Vector3(position.x + speedToTarget.x, position.y + speedToTarget.y, position.z + speedToTarget.z);
    }
	
	
	Vector3 SpeedToTarget(Vector3 toNorm) {
		return Vector3.Normalize(toNorm) * bulletSpeed;
	}
}
