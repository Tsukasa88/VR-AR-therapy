using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Returnbtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Return()
	{
		#if UNITY_5_3 || UNITY_5_3_OR_NEWER
		SceneManager.LoadScene ("Language");
		#else
		Application.LoadLevel ("Language");
		#endif
	}
}
