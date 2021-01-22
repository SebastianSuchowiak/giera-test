using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
	
	public List<Transform> targets;
	public Transform bulletPrefab;
	public float fireRate;
	
    // Start is called before the first frame update
    void Start()
    {
        targets = new List<Transform>();
		StartCoroutine("Shoot");
    }
	
	void Awake () {
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 60;
	}
	
    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter (Collider  col) {
		targets.Add(col.transform);
	}
	
	void OnTriggerExit (Collider  col) {
		targets.Remove(col.transform);
	}
	
	IEnumerator Shoot()
	{	
	    for(;;) {
			yield return new WaitForSeconds(fireRate);
			if (targets.Count > 0) {
				aimAndShoot();
			}
		}
	}
	
	void aimAndShoot() {
		Transform bulletTransform = Instantiate(bulletPrefab, transform);
		Bullet bullet = bulletTransform.GetComponent<Bullet>();
		bullet.target = targets[0].position - transform.position;
	}
}
