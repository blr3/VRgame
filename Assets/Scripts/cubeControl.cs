using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour
{
	public Material[] materials;
	public int totalScore = 0;
    // Start is called before the first frame update
    void Awake() 
    {
		Renderer rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = materials[Random.Range(0,(materials.Length))]; 
	}
    void Start()
    {

       //WaitForSeconds(5);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey("right")) {
			transform.Translate(0.1f,0,0);
		}
		if (Input.GetKey("left")) {
			transform.Translate(-0.1f,0,0);
		}
		if (Input.GetKey("up")) {
			transform.Translate(0,0,0.1f);
		}
		if (Input.GetKey("down")) {
			transform.Translate(0,0,-0.1f);
		}
        
    }
    
    /*
    void OnCollisionEnter(Collision col) 
    {
		/*
		foreach (ContactPoint contact in col.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);
		}
	}
	*/
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("trigger detected");
		Renderer rend = other.gameObject.GetComponent<Renderer>();
		if (other.gameObject.CompareTag("Droplet"))
		{
			if (rend.sharedMaterial.name == GetComponent<Renderer>().sharedMaterial.name) {
				totalScore += 1;
			} else {
				Destroy(gameObject);
			}
		}
	}
}
