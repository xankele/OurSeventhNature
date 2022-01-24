using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform Player;

	public float m_speed = 0.1f; //nazwy _
	Camera mycam;



	public void Start()
	{
		mycam = GetComponent<Camera>();
	}

	public void Update()
	{

		mycam.orthographicSize = (Screen.height / 100f) / 0.5f;


		if (Player)
		{

			transform.position = Vector3.Lerp(transform.position, Player.position, m_speed) + new Vector3(0, 2, -12);
		}


	}

}
