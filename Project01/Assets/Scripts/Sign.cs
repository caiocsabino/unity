using UnityEngine;
using System.Collections;

public class Sign : MonoBehaviour {
	
	private bool m_playerInRange = false;
	
	public Texture2D background;
	
	private bool m_showingMessage = false;
	
	public Vector2 m_sizeRatios = new Vector2(0.8f, 0.8f);
	public Vector2 m_textAreaPosRatios = new Vector2(0.55f, 0.2f);
	public Vector2 m_textAreaSizeRatios = new Vector2(0.3f, 0.58f);
	
	public string m_textClose = "Close";
	public Vector2 m_closePosRatio = new Vector2(0.11f, 0.12f);
	public Vector2 m_closeSize = new Vector2(50,20);
	
	public string m_text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown()
	{
		if (m_playerInRange) 
		{
			m_showingMessage = true;
			Debug.Log ("click");
			
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			//player.SetActive(false);
		}
	}
	
	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			m_playerInRange = true;
			
			
		}
	}
	
	void OnGUI () 
	{
		Debug.Log ("picles");
		if (m_showingMessage) 
		{
			//if (GUI.Button (new Rect (10, 10, 100, 50), icon)) {
			//		print ("you clicked the icon");
			//}
			
			Rect imageRect = new Rect(Screen.width * 0.5f - Screen.width * m_sizeRatios.x * 0.5f, 
			                          Screen.height * 0.5f - Screen.height * m_sizeRatios.y * 0.5f, 
			                          Screen.width * m_sizeRatios.x,
			                          Screen.height * m_sizeRatios.y);
			
			GUI.DrawTexture(imageRect, background);
			
			Rect textAreaRect = new Rect(Screen.width * m_textAreaPosRatios.x, 
			                             Screen.height * m_textAreaPosRatios.y,
			                             Screen.width * m_textAreaSizeRatios.x,
			                             Screen.height * m_textAreaSizeRatios.y
			                             );
			Color colorSave = GUI.color;
			GUI.color = Color.white;
			string textAreaString = GUI.TextArea (textAreaRect, m_text);
			GUI.color = colorSave;
			
			if (GUI.Button (new Rect (Screen.width * m_closePosRatio.x, Screen.height * m_closePosRatio.y, m_closeSize.x, m_closeSize.y), m_textClose)) {
				GameObject player = GameObject.FindGameObjectWithTag("Player");
				player.SetActive(true);
				m_showingMessage = false;
			}
		}
	}
	
	
	public void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			m_playerInRange = false;
			m_showingMessage = false;
		}
	}}
