using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class UpdateEvent : MonoBehaviour
{

	public UnityEvent Event;
	
	void Update () {
		Event.Invoke();
	}
}
