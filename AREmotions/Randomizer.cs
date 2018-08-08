using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Randomizer : MonoBehaviour {

	public AudioClip[] questions;
	public static string currentObjectTag;
	public static bool reacted;
	private int i;
	private int nbrQ;

	public AudioClip shih;
	public AudioClip ghalet;

	private bool randomized;

	private AudioSource myAudioSource;

	void Start () {
		reacted = true;
		randomized = false;
		nbrQ = 0;
		myAudioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if ((!randomized) && (nbrQ < 10))  {
			i = (int)Random.Range (0, questions.Length);
			myAudioSource.PlayOneShot (questions [i]);
			randomized = true;
			nbrQ++;
		}

		print (i);

		if ((i.ToString () == currentObjectTag) && !reacted) {
			print ("s7i7");
			myAudioSource.PlayOneShot (shih);
			reacted = true;
			randomized = false;
		} else if ((i.ToString () != currentObjectTag) && !reacted) {
			print ("ghalet");
			myAudioSource.PlayOneShot (ghalet);
			reacted = true;
		}
		 
		if (nbrQ == questions.Length) {
			myAudioSource.PlayOneShot (shih);
			SceneManager.LoadScene ("Language");
		}

	}
}
