using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal2Script : MonoBehaviour {

	void Start() {
		Debug.Log ("script started");
		Debug.Log (gameObject.name);
	}

	void Update (){
	}

	void OnTriggerEnter (Collider col){
		//void OnCollisionEnter (Collider col){

		SceneManager.LoadScene ("golconda", LoadSceneMode.Additive);
		Debug.Log ("entered scene");


		//Debug.Log ("outside if");
	}
}
