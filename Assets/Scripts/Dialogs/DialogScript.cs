using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogScript : MonoBehaviour {
	public static DialogScript instance;
	public int index = 1;
	public string dialog;
	public Text askText;
	public Text[] answers;
	[HideInInspector]
	public bool sh = false;
	void Awake(){
		instance = this;
		transform.gameObject.SetActive (false);
	}
	void Update(){
		if (sh) {
			Show();
		}
	}
	public void Show(){
		askText.text = dialog.Substring (dialog.IndexOf ("T" + index) + ("T" + index).Length + 1,
		                                (dialog.IndexOf ("/T" + index) - ("/T" + index).Length * 2) - dialog.IndexOf ("T" + index) + ("T" + index).Length + 1);

		for(int x=0;x<answers.Length;x++){
			if(dialog.IndexOf ("A/"+index+"/"+(x+1)+"/")!=-1){
				answers[x].gameObject.SetActive(true);
					answers[x].text =  dialog.Substring(dialog.IndexOf ("A/"+index+"/"+(x+1)+"/")+("A/"+index+"/"+(x+1)+"/").Length,
				                 dialog.IndexOf ("/A/"+index+"/"+(x+1)) - ("/A/"+index+"/"+(x+1)).Length*2 - dialog.IndexOf ("A/"+index+"/"+(x+1)+"/")+("A/"+index+"/"+(x+1)+"/").Length);
				string ind = dialog.Substring(dialog.IndexOf ("!"+index+"/"+(x+1)+"/") + ("!"+index+"/"+(x+1)+"/").Length,dialog.IndexOf ("A/"+index+"/"+(x+1)+"/") - dialog.IndexOf ("!"+index+"/"+(x+1)+"/") - ("!"+index+"/"+(x+1)+"/").Length);
				answers[x].GetComponent<AnswerButtonScript>().index = ind;
				answers[x].GetComponent<AnswerButtonScript>().dialog = this;
			}
			else{
				answers[x].gameObject.SetActive(false);
			}
		}
	}
	public void Close(){
		sh = false;
		transform.gameObject.SetActive (false);
	}
}
