using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour {

	void Start() {
		Debug.Log ("script started");
		Debug.Log (gameObject.name);
	}

	void Update (){
	}

	void OnTriggerEnter (Collider col){
	//void OnCollisionEnter (Collider col){

			SceneManager.LoadScene ("ScrewAndStump", LoadSceneMode.Additive);
			Debug.Log ("entered scene");


		//Debug.Log ("outside if");
	}
}
