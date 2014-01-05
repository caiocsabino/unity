using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {

	public GameObject m_rotator;
	private Rotator m_rotatorComponent;

	private GameObject m_lever;

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

			GameObject actualLever = transform.FindChild("actualLever").gameObject;

			if(actualLever)
			{
				actualLever.transform.Rotate (new Vector3 (0, 1, 0), -90);
			}
		}
	}
}
