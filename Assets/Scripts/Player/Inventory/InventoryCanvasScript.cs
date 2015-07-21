using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InventoryCanvasScript : MonoBehaviour {
	public InventoryGridBlock[] inventory;
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
		GameItem item = null;
		if(inventory[to].itemInMe)item = inventory[to].itemInMe;
		inventory[to].itemInMe  = inventory[from].itemInMe;
		inventory[from].itemInMe = item;
	}
}
