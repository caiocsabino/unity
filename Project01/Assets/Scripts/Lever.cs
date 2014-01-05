using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {

	public GameObject m_rotator;
	private Rotator m_rotatorComponent;

	private GameObject m_lever;

	private float m_animationTimer = -1.0f;

	private float m_currentAngle = 270.0f;

	private float m_totalAnimationTime = 0.5f;

	private float m_startAngle = 270;
	private float m_endAngle = 360;

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
		if (m_animationTimer > -1) 
		{
			m_animationTimer += Time.deltaTime;
			m_animationTimer = Mathf.Min(m_animationTimer, m_totalAnimationTime);

			float ratio = (m_animationTimer/m_totalAnimationTime);
			m_currentAngle =  m_startAngle + (m_endAngle - m_startAngle) * ratio;

			GameObject actualLever = transform.FindChild("actualLever").gameObject;
			
			if(actualLever)
			{
				actualLever.transform.rotation = Quaternion.AngleAxis(m_currentAngle, new Vector3(1,0,0));
			}

			if(m_animationTimer == m_totalAnimationTime)
			{
				m_animationTimer = -1.0f;

				m_rotatorComponent.ToggleRotation();
			}
		}
	}

	public void Activate()
	{
		Debug.Log ("lever activated");
		if (m_rotatorComponent) 
		{

			if (m_animationTimer < 0) 
			{
				m_animationTimer = 0;
				m_startAngle = m_currentAngle;
				m_endAngle = m_startAngle + 90;

			}
		}
	}
}
