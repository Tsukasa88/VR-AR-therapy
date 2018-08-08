using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class VBloadsceneEventHandler : MonoBehaviour, IVirtualButtonEventHandler {


	private GameObject vbButtonObject;
	// Use this for initialization
	void Start () {

		vbButtonObject = GameObject.Find ("btn");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("downbtn1");
		English ();
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log("OnButtonReleased");
	}



	// Update is called once per frame
	void Update () {

	}

	public void English()
	{
		#if UNITY_5_3 || UNITY_5_3_OR_NEWER
		SceneManager.LoadScene ("English");
		#else
		Application.LoadLevel ("English");
		#endif
	}

}
