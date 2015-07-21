using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventoryGridBlock : MonoBehaviour {
	public GameItem itemInMe;
	public InventoryCanvasScript inventoryManager;
	public int index;
	[HideInInspector]
	public GameItem inMe;
	[HideInInspector]
	public Image myImage;

	float sTime;
	void Awake(){
		myImage = GetComponent<Image>();
	}

	void Update(){
		if(itemInMe){
			GetComponent<Image>().sprite = itemInMe.icon; 
			GetComponent<Image>().color = itemInMe.color;
		}
		else{
			GetComponent<Image>().sprite = null; 
			GetComponent<Image>().color = new Color(0,0,0,0);
		}
		if( 
			Mathf.Abs(Input.mousePosition.x - GetComponent<RectTransform>().position.x)<GetComponent<RectTransform>().rect.width/2
			&&
			Mathf.Abs(Input.mousePosition.y - GetComponent<RectTransform>().position.y)<GetComponent<RectTransform>().rect.height/2
			){
			//sTime = Time.time;
			if(Input.GetMouseButton(0)){
				inventoryManager.setInt(index);
			}
			else if(Input.GetMouseButton(1)){
				
			}
		}
	}

}
