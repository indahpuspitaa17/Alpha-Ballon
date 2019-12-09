using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour {

	public GameObject MenuPanel;
	public GameObject InfoPanel;

	void Start () {
		MenuPanel.SetActive (true);
		InfoPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
public void MainClicked()
{
	Application.LoadLevel("pecahkan balon");
}
public void InfoClicked()
{
	MenuPanel.SetActive(false);
	InfoPanel.SetActive (true);
}
public void Quit_clicked()
{
	Application.Quit();
}
	public void KembaliClicked()
	{
		MenuPanel.SetActive (true);
		InfoPanel.SetActive (false);
	}
}
