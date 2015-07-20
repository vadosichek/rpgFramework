using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour {
	Vector3 targetPos;
	public NavMeshAgent agent;
	void Setup(){
		agent = GetComponent<NavMeshAgent> ();

	}
	bool guiIsActive = false;
	void Update(){
		guiIsActive = false;
		foreach(Canvas cn in GameObject.FindObjectsOfType<Canvas>()){
			if(cn.gameObject.activeSelf){
				guiIsActive = true;
			}
		}
		foreach(NpcActionsTemplateScript cn in GameObject.FindObjectsOfType<NpcActionsTemplateScript>()){
			if(cn.gameObject.activeSelf){
				guiIsActive = true;
			}
		}
		if (!guiIsActive && Input.GetMouseButtonDown(0) && GUIUtility.hotControl ==0) {
			
			Plane playerPlane = new Plane(Vector3.up, transform.position);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			float hitdist = 0.0f;
			
			if (playerPlane.Raycast(ray, out hitdist)) {
				targetPos= ray.GetPoint(hitdist);
			}
			agent.SetDestination (targetPos);
		}

	}
}
