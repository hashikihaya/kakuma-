using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int count = GameObject.FindGameObjectsWithTag("Dmura").Length;
        if(count == 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
	}
}
