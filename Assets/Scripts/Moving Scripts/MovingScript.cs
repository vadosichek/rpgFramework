using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour {
	Vector3 targetPos;
	public NavMeshAgent agent;
	void Setup(){
		agent = GetComponent<NavMeshAgent> ();

	}
	void Update(){
		if (Input.GetMouseButtonDown(0)&& GUIUtility.hotControl ==0) {
			
			Plane playerPlane = new Plane(Vector3.up, transform.position);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			float hitdist = 0.0f;
			
			if (playerPlane.Raycast(ray, out hitdist)) {
				Vector3 targetPoint = ray.GetPoint(hitdist);
				targetPos= ray.GetPoint(hitdist);
			}
			agent.SetDestination (targetPos);
		}

	}
}
