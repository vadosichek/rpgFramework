using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogScript : MonoBehaviour {
	public int index = 1;
	public string dialog= 
		"T1/Hello, player 1/T1 !1/1/2A/1/1/Hello, npc 2!/A/1/1" +
			"T2/Hello, player 2/T2 !2/1/1A/2/1/Hello, npc 1!/A/2/1";
	public Text askText;
	public Text[] answers;

	void Update(){
		Show ();
	}

	void Show(){
		askText.text = dialog.Substring (dialog.IndexOf ("T" + index) + ("T" + index).Length + 1,
		                                (dialog.IndexOf ("/T" + index) - ("/T" + index).Length * 2) - dialog.IndexOf ("T" + index) + ("T" + index).Length + 1);

		for(int x=0;x<answers.Length;x++){
			if(dialog.IndexOf ("A/"+index+"/"+(x+1)+"/")!=-1){
				answers[x].gameObject.SetActive(true);
					answers[x].text =  dialog.Substring(dialog.IndexOf ("A/"+index+"/"+(x+1)+"/")+("A/"+index+"/"+(x+1)+"/").Length,
				                 dialog.IndexOf ("/A/"+index+"/"+(x+1)) - ("/A/"+index+"/"+(x+1)).Length*2 - dialog.IndexOf ("A/"+index+"/"+(x+1)+"/")+("A/"+index+"/"+(x+1)+"/").Length);
				answers[x].GetComponent<AnswerButtonScript>().index = int.Parse(dialog.Substring(dialog.IndexOf ("!"+index+"/"+(x+1)+"/") + ("!"+index+"/"+(x+1)+"/").Length,dialog.IndexOf ("A/"+index+"/"+(x+1)+"/") - dialog.IndexOf ("!"+index+"/"+(x+1)+"/") - ("!"+index+"/"+(x+1)+"/").Length));
				answers[x].GetComponent<AnswerButtonScript>().dialog = this;
			}
			else{
				answers[x].gameObject.SetActive(false);
			}
		}
	}
	
}
