using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float m_angleSpeed = 20.0f;
	private bool m_rotationEnabled = false;

	void Update ()
	{
		if(m_rotationEnabled)
			transform.Rotate(new Vector3(1,0,0), m_angleSpeed * Time.deltaTime);
	}

	public void ToggleRotation()
	{
		m_rotationEnabled = !m_rotationEnabled;
	}
}