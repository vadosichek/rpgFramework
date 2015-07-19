using UnityEngine;
using System.Collections;

public class AnswerButtonScript : MonoBehaviour {
	public DialogScript dialog;
	public int index;
	public void setIndex(){
		dialog.index = index;
	}
}
