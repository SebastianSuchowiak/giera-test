using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
	
	float speed = 0.004f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 position = this.transform.position;
        this.transform.position = new Vector3(position.x - speed, position.y, position.z);
    }
}
