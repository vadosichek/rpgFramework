using UnityEngine;
using System.Collections;

public class NpcActionsTemplateScript : MonoBehaviour {
	public NpcActionButtonScript[] actionButtons;
	public void selectNpc(GameObject npc){
		foreach(NpcActionButtonScript act in actionButtons){
			act.npc = npc;
		}
	}
}
