using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public GameObject[] m_sceneLevers;

	// Use this for initialization
	void Start () {
		m_sceneLevers = GameObject.FindGameObjectsWithTag("lever");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
