using UnityEngine;
using System.Collections;

public class NpcActionBase : MonoBehaviour {
	protected virtual void DoAction(){}
	public void doAction(){DoAction ();}
}
