using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainingmen : MonoBehaviour {

	public Transform men;
	public Quaternion rotation = Quaternion.identity;


	// Use this for initialization
	void Start () {
		for (int y = 0; y < 20; y = y+5) {
			for (int x = -38; x < 42; x = x+5) {
				for (int z = -45; z < 35; z = z + 5) {
					float rotationAmount = Random.Range (0f, 359f);
					rotation.eulerAngles = new Vector3 (0, rotationAmount, 0);
					Instantiate(men, new Vector3(x, y, z), rotation);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
