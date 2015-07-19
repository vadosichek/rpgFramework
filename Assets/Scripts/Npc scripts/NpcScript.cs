using UnityEngine;
using System.Collections;

public class NpcScript : MonoBehaviour {
	public PlayerScript player;
	public NpcActionBase action;
	public float activeZoneRadius;
	public bool passive;
	public bool activated;
	Vector3 playerPos;
	void Update(){
		player = PlayerScript.instance;
		if(player){
			playerPos = new Vector3(player.transform.position.x,transform.rotation.y,player.transform.position.z);
			if(Vector3.Distance(transform.position,playerPos) <= activeZoneRadius){
				if(!passive){
					action.doAction();
				}
				activated = true;
			}
			else{
				activated = false;
			}
		}
	}

	void OnMouseDown(){
		if(activated){
			action.doAction();
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, activeZoneRadius);
	}
}
