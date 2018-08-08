using UnityEngine;
using System.Collections;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace loadlevels
{

	public class loadlevels : MonoBehaviour
	{

		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update ()
		{

		}

		public void English()
		{
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("English");
			#else
			Application.LoadLevel ("English");
			#endif
		}


		public void Francais()
		{
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("Français");
			#else
			Application.LoadLevel ("Français");
			#endif
		}

		public void Arabe()
		{
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("Arabe");
			#else
			Application.LoadLevel ("Arabe");
			#endif
		}

		public void QuizEnglish()
		{
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("QENGLISH");
			#else
			Application.LoadLevel ("QENGLISH");
			#endif
		}

		public void QuizFrançais()
		{
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("QFRANCAIS");
			#else
			Application.LoadLevel ("QFRANCAIS	");
			#endif
		}

		public void QuizArabe()
		{
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("QARABE");
			#else
			Application.LoadLevel ("QARABE");
			#endif
		}

		public void ReturnLg()
		{
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("Language");
			#else
			Application.LoadLevel ("Language");
			#endif
		}

		public void QuitApp()
		{
			Application.Quit();

		}
	}
}