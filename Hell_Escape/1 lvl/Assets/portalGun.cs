using UnityEngine;
using System.Collections;

public class portalGun : MonoBehaviour {
	public float gunRange = 1000;
	public Transform portal;


	private Vector3 portalNormal;
	public GameObject player;
	// Use this for initialization
	void Start () {
		//portals = GameObject.FindObjectOfType<flash>();
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown(0))
		{
			Vector3 position = Camera.main.transform.position;
			RaycastHit raycastHit = new RaycastHit();
			if (Physics.Linecast (position, position +Camera.main.transform.forward * gunRange, out raycastHit, 1 ))
			{
				MovePortal(raycastHit);
			}
		}
	}

	public void MovePortal(RaycastHit raycastHit)
	{
		portalNormal = raycastHit.normal;
		transform.position = raycastHit.point;
		Vector3 exitPosition = transform.position + portalNormal * 2;
		player.transform.position = exitPosition;
	}
}
