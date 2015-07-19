using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public static PlayerScript instance;
	void Awake(){
		instance = this;
	}
}
