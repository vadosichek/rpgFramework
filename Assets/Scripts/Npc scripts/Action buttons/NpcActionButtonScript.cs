using UnityEngine;
using System.Collections;

public class NpcActionButtonScript : MonoBehaviour {
	public int actionType;
	public GameObject npc;
	public DialogParticipantScript act;
	void OnMouseDown(){
		if(actionType == 1){
			act = npc.GetComponent<DialogParticipantScript>();
			npc.GetComponent<DialogParticipantScript>().doAction();
			transform.parent.gameObject.SetActive(false);
		}
	}
}
