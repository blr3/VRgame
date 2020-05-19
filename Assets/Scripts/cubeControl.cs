using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
	
	void OnTriggerEnter(Collider other)
	{
		Renderer rend = other.gameObject.GetComponent<Renderer>();
		if (other.gameObject.CompareTag("Droplet"))
		{
			if (rend.sharedMaterial.name == GetComponent<Renderer>().sharedMaterial.name) {
				totalScore += 1;
			} else {
				Destroy(gameObject);
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
		}
	}
}
