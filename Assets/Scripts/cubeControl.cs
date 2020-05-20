using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubeControl : MonoBehaviour
{
	public AudioClip ding;
	AudioSource myAudioSource;

	public Material[] materials;
	public int totalScore = 0;
	public int points = 1;
	public GameObject plane;
    // Start is called before the first frame update
    void Awake()
    {
		myAudioSource = GetComponent<AudioSource>();

		Renderer rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = materials[Random.Range(0,(materials.Length))];
	}

    // Update is called once per frame
    void Update()
    {
		//float xMax = plane.GetComponent<Renderer>().bounds.max.x;
		//float zMax = plane.GetComponent<Renderer>().bounds.max.z;
		float yMax = plane.GetComponent<Renderer>().bounds.max.y;

		//float xPos = Mathf.Abs(gameObject.GetComponent<Transform>().position.x);
		//float zPos = Mathf.Abs(gameObject.GetComponent<Transform>().position.z);
		float yPos = Mathf.Abs(gameObject.GetComponent<Transform>().position.y);

		//if (xPos > xMax || zPos > zMax) {
		if (Mathf.Abs(yPos - yMax) > 100) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
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
				totalScore += points;
				Destroy(other.gameObject);

				myAudioSource.PlayOneShot(ding);
			} else {
				Destroy(gameObject);
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

			}
		}
	}
}
