using UnityEngine;
using UnityEditor;
using System.Collections;
public class GridBuilder : EditorWindow {
	int index = 1;
	string dialog = 
		"T1/Hello, player 1/T1 !1/1/2A/1/1/Hello, npc 2!/A/1/1 !1/2/3A/1/2/Hello, npc 3!/A/1/2" +
		"T2/Hello, player 2/T2 !2/1/1A/2/1/Hello, npc 1!/A/2/1";
	// Window has been selected
	[MenuItem ("FrameWork/Dialog builder")]
	static void Init () {
		// Get existing open window or if none, make a new one:
		GridBuilder window = (GridBuilder)EditorWindow.GetWindow (typeof (GridBuilder));
		window.Show();
	}
	void OnGUI(){
		GUILayout.Label ("Building dialog");
		index = EditorGUILayout.IntField (index);

		GUILayout.Label (
			dialog.Substring(dialog.IndexOf("T"+index)+("T"+index).Length+1,
		                 (dialog.IndexOf("/T"+index)-("/T"+index).Length*2)-dialog.IndexOf("T"+index)+("T"+index).Length+1)
			);

		for(int x=1;x<=2;x++){
			if(dialog.IndexOf ("A/"+index+"/"+x+"/")!=-1){
				//GUILayout.Label(dialog.Substring(dialog.IndexOf ("!"+index+"/"+x+"/") + ("!"+index+"/"+x+"/").Length,dialog.IndexOf ("A/"+index+"/"+x+"/") - dialog.IndexOf ("!"+index+"/"+x+"/") - ("!"+index+"/"+x+"/").Length));
				if(GUILayout.Button(
					dialog.Substring(dialog.IndexOf ("A/"+index+"/"+x+"/")+("A/"+index+"/"+x+"/").Length,
				    dialog.IndexOf ("/A/"+index+"/"+x) - ("/A/"+index+"/"+x).Length*2 - dialog.IndexOf ("A/"+index+"/"+x+"/")+("A/"+index+"/"+x+"/").Length
			        ))){
					index=int.Parse(dialog.Substring(dialog.IndexOf ("!"+index+"/"+x+"/") + ("!"+index+"/"+x+"/").Length,dialog.IndexOf ("A/"+index+"/"+x+"/") - dialog.IndexOf ("!"+index+"/"+x+"/") - ("!"+index+"/"+x+"/").Length));
				}
			}
		}

	}
}
