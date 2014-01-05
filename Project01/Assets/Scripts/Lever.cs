using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {

	public GameObject m_rotator;
	private Rotator m_rotatorComponent;

	// Use this for initialization
	void Start () 
	{
		if (m_rotator) 
		{
			m_rotatorComponent = m_rotator.GetComponent<Rotator>();
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Activate()
	{
		Debug.Log ("lever activated");
		if (m_rotatorComponent) 
		{
			m_rotatorComponent.ToggleRotation();
		}
	}
}
