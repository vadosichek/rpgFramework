using UnityEngine;
using System.Collections;

public class DialogParticipantScript : NpcActionBase {
	public DialogScript dialog;
	[System.NonSerialized]
	public string dialogtText= 
		"T1/Hello, player 1/T1 !1/1/2A/1/1/Hello, npc 2!/A/1/1 T2/Hello, player 2/T2 !2/1/cA/2/1/Hello, npc 3!/A/2/1";
	void Awake(){
		if(!dialog)dialog = DialogScript.instance;
	}
	protected override void DoAction ()
	{
		if(dialog){
			dialog.dialog = dialogtText;
			dialog.gameObject.SetActive(true);
			dialog.sh = true;
		}
	}
}
