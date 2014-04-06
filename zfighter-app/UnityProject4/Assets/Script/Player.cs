using UnityEngine;
using System.Collections;



public class Player : MonoBehaviour {

	private string FirstName;
	private string zFighter_obtenus;


	// Use this for initialization
	void Start () {
		this.FirstName = "Test";
		this.zFighter_obtenus = "Moah";
	}
	
	public string getName()
	{
		return this.FirstName;
	}

	public string getzFighter()
	{
		return this.zFighter_obtenus;
	}
	// Update is called once per frame
	void Update () {
	
	}
}