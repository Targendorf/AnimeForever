using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour {
	void Start () {	
	}
	void OnMouseUpAsButton()
    {
        switch (gameObject.name) {
            case "New Game":
            SceneManager.LoadScene("MetalBear");
                break;
        }
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    } 
}
