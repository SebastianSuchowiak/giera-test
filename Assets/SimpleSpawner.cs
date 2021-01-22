using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
	
	public Transform mob;
	public float spawnPeriod = 0.5f;
	float timer;
	
    // Start is called before the first frame update
    void Start()
    {
		//StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
		if(timer > spawnPeriod){
			Instantiate(mob, transform);
			timer = 0;
		}
    }
	
	IEnumerator Spawn() 
	{	
	    for(;;) {
			yield return new WaitForSeconds(spawnPeriod);
			Instantiate(mob, transform);
		}
	}	

}
