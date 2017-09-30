using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class LandOnConcreteEvent : MonoBehaviour {
	private AudioSource audioSource;

	void Awake () 
	{
		audioSource = GetComponent <AudioSource>();
	}

	void OnEnable () 
	{
		EventManager.StartListening ("LandOnConcrete", PlaySound);
	}

	void OnDisable () 
	{
		EventManager.StopListening ("LandOnConcrete", PlaySound);
	}

	void PlaySound () 
	{
		Debug.Log ("Here!!!!");
		EventManager.StopListening ("LandOnConcrete", PlaySound);
		audioSource.Play ();
	}
}