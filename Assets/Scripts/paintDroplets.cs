using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintDroplets : MonoBehaviour
{
	public float seconds;
	public Material[] materials;
	public Transform cube;
	public int levelTwoVal;
	public int levelThreeVal;
	public GameObject paintDroplet;
	public int drag;
    // Start is called before the first frame update
    void Start()
    {
		drag = 1;
		levelTwoVal = 10;
		levelThreeVal = 30;
		seconds = 1.5f;
		StartCoroutine("MakeDroplets");
    }

        // Update is called once per frame
    void Update() {
		if (cube != null) {
			if (cube.GetComponent<cubeControl>().totalScore >= levelThreeVal) {
					Debug.Log("reached level 3");
					seconds = 0.35f;
					cube.GetComponent<cubeControl>().points = 5;
					drag = 0;
			} else if (cube.GetComponent<cubeControl>().totalScore >= levelTwoVal) {
					Debug.Log("reached level 2");
					seconds = 0.5f;
					cube.GetComponent<cubeControl>().points = 2;
					drag = 0;
			}
		}
	}

    IEnumerator MakeDroplets()
    {
		while (true) {
			GameObject item = Instantiate(paintDroplet, new Vector3(Random.Range(-4f,4f),10,Random.Range(-4f,4f)), Quaternion.identity);
			Renderer rend = item.GetComponent<Renderer>();
			rend.sharedMaterial = materials[Random.Range(0,(materials.Length))];
			item.GetComponent<Rigidbody>().drag = drag;
			yield return new WaitForSeconds(seconds);
		}
    }
}
