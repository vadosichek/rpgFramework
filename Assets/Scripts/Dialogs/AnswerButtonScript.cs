using UnityEngine;
using System.Collections;

public class AnswerButtonScript : MonoBehaviour {
	public DialogScript dialog;
	public string index;
	public void setIndex(){
		if(!index.Equals("c")){dialog.index = int.Parse(index);}
		else{dialog.Close();}
	}
}
