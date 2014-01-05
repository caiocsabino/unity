using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	private GameObject m_manager;
	private Manager m_managerScript;


	public float activationSquareDistance = 16.0f;

	// Use this for initialization
	void Start () 
	{
		m_manager = GameObject.FindGameObjectWithTag("gameManager");
		m_managerScript = m_manager.GetComponent<Manager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown (KeyCode.Return)) 
		{

			GameObject [] levers = m_managerScript.m_sceneLevers;


			for(int i = 0; i < levers.Length; i++)
			{
				GameObject leverObj = levers[i];
				Lever lever = leverObj.GetComponent<Lever>();

				Vector3 leverPos = leverObj.transform.position;

				Vector3 myPos = transform.position;


				float squaredDistance = (leverPos.x - myPos.x) * (leverPos.x - myPos.x) + (leverPos.y - myPos.y) * (leverPos.y - myPos.y) + (leverPos.z - myPos.z) * (leverPos.z - myPos.z);


				if(squaredDistance < activationSquareDistance)
				{
					Debug.Log ("distance to lever " + squaredDistance + " activationSquareDistance " + activationSquareDistance);

					lever.Activate();
					break;
				}
			}
		}
	}
}
