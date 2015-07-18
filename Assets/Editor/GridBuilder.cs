using UnityEngine;
using UnityEditor;
using System.Collections;

public class GridBuilder : EditorWindow {
	Transform gridPart;
	Color baseColor = Color.black;
	Color onMouseColor = Color.red;
	int width=0,height=0;
	Transform gridParent;
	[MenuItem ("FrameWork/Grid building")]
	static void Init(){
		GridBuilder window = (GridBuilder)EditorWindow.GetWindow (typeof (GridBuilder));
		window.Show();
	}
	int x=0;
	void OnGUI () {
		if(x==0){
			if(GUILayout.Button("Build grid")){x=1;}
			if(GUILayout.Button("Grid settings")){x=2;}
		}
		else if(x==1){
			GUILayout.Label("Building grid");
			gridPart = EditorGUILayout.ObjectField("Grid block",gridPart,typeof(Transform),true) as Transform;
			gridParent = EditorGUILayout.ObjectField("Grid parent",gridParent,typeof(Transform),true) as Transform;
			width = EditorGUILayout.IntField("Grid width",width);
			if(width%2!=0){width--;}
			height = EditorGUILayout.IntField("Grid height",height);
			if(height%2!=0){height--;}
			baseColor = EditorGUILayout.ColorField("Grid block base color",baseColor);
			onMouseColor = EditorGUILayout.ColorField("Grid block on mouse over color",onMouseColor);
			if(gridParent && gridPart){
				if(GUILayout.Button("Build grid")){
					x=0;
				}
			}
			else{
				GUILayout.Space(40);
				GUILayout.Label("Select grid parent and grid part");
			}

		}
		else if(x==2){
			GUILayout.Label("Changing grid block settings");
			baseColor = EditorGUILayout.ColorField("Grid block base color",baseColor);
			onMouseColor = EditorGUILayout.ColorField("Grid block on mouse over color",onMouseColor);
			if(GUILayout.Button("Change grid block settings")){
				x=0;
			}
		}
	}
}
