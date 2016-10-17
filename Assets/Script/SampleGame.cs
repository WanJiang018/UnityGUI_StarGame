using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SampleGame : MonoBehaviour {
	public GUISkin skin;
	public GameObject textureObject;
	
	private Rect LabelRect;
	private Rect buttonRect;
	private List<GameObject> textureList;

	void Start () {
		LabelRect = new Rect (0,Screen.height-30,100,30);
		buttonRect = new Rect (0,0,100,45);
		textureList = new List<GameObject> ();
	}
	

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 position=Input.mousePosition;
			position.x/=Screen.width;
			position.y/=Screen.height;
			
			GameObject star=(GameObject)Instantiate(textureObject,position,Quaternion.identity);
			
			textureList.Add (star);
		}
	}
	
	void OnGUI(){
		GUI.Label (LabelRect, textureList.Count.ToString (), skin.label);
		if(GUI.Button (buttonRect,"Clear",skin.button)){
			foreach(GameObject star in textureList){
				Destroy(star,0);
			}
		}
		
		if (GUI.Button (new Rect (0, 55, 100, 45), "END", skin.button)) {
			foreach(GameObject star in textureList){
				Destroy(star,0);
			}
			textureList.Clear ();
			
			SampleMenu menu = gameObject.GetComponent<SampleMenu> ();
			menu.enabled = true;
			this.enabled = false;
		}
		
		
		
	}
}
