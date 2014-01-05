using UnityEngine;
using System.Collections;

public class Windmill : MonoBehaviour {

	private GameObject m_door;
	// Use this for initialization
	void Start () {
		m_door = transform.FindChild("prefab_windmill_door").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			Debug.Log ("Trigger entered on windmill");

			if(m_door)
			{
				//Animation openAnimation = m_door.GetComponent<Animation>();
				//openAnimation.Play();
				m_door.transform.animation.Play("anim_door_open");
				//m_door.transform.Rotate(new Vector3(0,1,0), 90);
			}
		}
	}
	public void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			Debug.Log ("Trigger exited on windmill");
			m_door.transform.animation.Play("anim_door_close");
			//m_door.transform.Rotate(new Vector3(0,1,0), -90);
		}
	}
}
