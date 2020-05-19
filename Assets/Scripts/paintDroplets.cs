using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintDroplets : MonoBehaviour
{
	public float delay = 4.5f;
	public float spawnTime = 1.5f;
	public GameObject paintDroplet;
	public bool stopSpawning = false;
	public Material[] materials;
	
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine("MakeDroplets");
        //InvokeRepeating("Spawn", spawnTime, delay);
    }

    // Update is called once per frame
    IEnumerator MakeDroplets()
    {
		/*
		Instantiate(paintDroplet, new Vector3(Random.Range(-6,6),10,0), Quaternion.identity);
        if (stopSpawning) {
			CancelInvoke("SpawnObject");
		}
		*/
		
		while (true) {
			GameObject item = Instantiate(paintDroplet, new Vector3(Random.Range(-5,5),10,Random.Range(-3,3)), Quaternion.identity);
			Renderer rend = item.GetComponent<Renderer>();
			rend.sharedMaterial = materials[Random.Range(0,(materials.Length))]; 
			yield return new WaitForSeconds(.5f);
		}
    }
    

}
