using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	public string m_sceneToLoad = "innerWindmill";


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			Debug.Log("Scene to load is " + m_sceneToLoad);
			Application.LoadLevel(m_sceneToLoad);

			GameObject player = GameObject.FindGameObjectWithTag("Player");

			GameObject spawnPoint = GameObject.FindGameObjectWithTag("Respawn");

			player.transform.position = spawnPoint.transform.position;
		}
	}
}
