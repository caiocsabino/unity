using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float m_angleSpeed = 20.0f;


	private int m_state = 0;

	void Update ()
	{
		if (m_state > 0) 
		{
			float speedMultiplier = (float)m_state / 3.0f;
			transform.Rotate (new Vector3 (1, 0, 0), m_angleSpeed * Time.deltaTime * speedMultiplier);
		}
	}

	public void ToggleRotation()
	{
		m_state += 1;
		m_state = m_state % 4;
	}
}