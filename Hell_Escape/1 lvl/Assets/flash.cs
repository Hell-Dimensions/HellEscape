//using UnityEngine;
//using System.Collections;
//
//public class flash : MonoBehaviour {
//	private Vector3 portalNormal;
//	private flash otherPortal;
//	private GameObject player;
//	private CharacterMotor cm;
//	private CharacterController cc;
//
//
//	// Use this for initialization
//	void Start () {
//		cm = GameObject.FindObjectOfType<CharacterMotor>();
//		cc = GameObject.FindObjectOfType<CharacterController>();
//		player = cc.gameObject;
//		//SetOtherPortal();
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
//
//	public void MovePlayerToThisPortal ()
//	{
//		// ustawianie velocity
//		Vector3 exitVelocity = portalNormal * cc.velocity.magnitude;
//		cm.SetVelocity(exitVelocity);
//		// ustawianie gdzie ma się pojawić player
//		Vector3 exitPosition = transform.position + otherPortal.portalNormal * 2;
//
//	}
//
//	public void MovePortal (RaycastHit raycastHit)
//	{		 
//		transform.position = raycastHit.point;
//		portalNormal = raycastHit.normal;
//	}
//}
