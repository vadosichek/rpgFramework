using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InventoryCanvasScript : MonoBehaviour {
	public Image[] inventory;
	int from;
	int to;
	bool selected = false;
	public void setInt(int index){
		if (!selected) {
			from = index;
			selected = true;
		} else {
			to = index;
			MoveObject();
		}
	}
	void MoveObject(){
		selected = false;
		Sprite objectSprite = inventory [to].sprite;
		Color objectColor = inventory [to].color;
		inventory [to].sprite = inventory [from].sprite;
		inventory [from].sprite = objectSprite;

		inventory [to].color = inventory [from].color;
		inventory [from].color = objectColor;
	}
}
