using UnityEngine;
using System.Collections;

public class SampleMenu : MonoBehaviour {
	public GUIStyle btnStyle;
	private Rect btnRect;
	private Rect endBtnRect;
	

	void Start () {
		btnRect = new Rect (Screen.width*2/5,Screen.height*2/5,256,64);
		endBtnRect = new Rect (Screen.width*2/5,Screen.height*2/5+74,256,64);
	}
	

	void OnGUI () {
		if (GUI.Button (btnRect, "Start Game", btnStyle)) {
			SampleGame game=gameObject.GetComponent<SampleGame>();
			game.enabled=true;
			this.enabled=false;
		}
		
		if(GUI.Button(endBtnRect,"End Game",btnStyle)){
			Application.Quit ();
		}
	}
}
