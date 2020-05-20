using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splatterPaint : MonoBehaviour
{
    public GameObject paintSprite;

    public AudioClip splat;
	AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision occurred");
        if (other.gameObject.CompareTag("Droplet"))
        {
            myAudioSource.PlayOneShot(splat);

            float dropletX = other.gameObject.GetComponent<Transform>().position.x;
            float dropletZ = other.gameObject.GetComponent<Transform>().position.z;

            Quaternion rotation = Quaternion.LookRotation(new Vector3(0,1,0));
            GameObject item = Instantiate(paintSprite, new Vector3(dropletX,0.0001f,dropletZ), rotation);

            Color dropColor = other.gameObject.GetComponent<Renderer>().material.color;
            item.GetComponent<Renderer>().material.SetColor("_Color", dropColor);
        }

    }
}
