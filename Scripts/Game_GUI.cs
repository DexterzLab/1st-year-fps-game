using UnityEngine;
using System.Collections;

public class Game_GUI : MonoBehaviour {

    public Texture crosshair;
    
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 2 - 16, Screen.height / 2 - 16, 32, 32), crosshair);
        
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
