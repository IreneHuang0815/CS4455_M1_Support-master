using UnityEngine;
using System.Collections;

public class EventTriggerTest : MonoBehaviour {


	void Update () {
		if (Input.GetKeyDown ("m"))
		{
			EventManager.TriggerEvent("LandOnConcrete");
		}

		if (Input.GetKeyDown ("o"))
		{
			EventManager.TriggerEvent("Spawn");
		}

		if (Input.GetKeyDown ("p"))
		{
			EventManager.TriggerEvent("Destroy");
		}

		if (Input.GetKeyDown ("x"))
		{
			EventManager.TriggerEvent("Junk");
		}
	}
}