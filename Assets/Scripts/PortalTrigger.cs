using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour {

	void Update {
		var portal1;


		function OnTriggerEnter (other Collider) {
			//Check to see if a player entered the gate, rather than some space debris.
			if (other.gameObject.CompareTag("Player")) {
				Application.LoadLevel("portal1");
			}
		}
}

}

	




