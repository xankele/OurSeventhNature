using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerWithBoss : MonoBehaviour
{
	public Transform Player;
	public Transform Boss;
	public float m_speed = 0.1f; //nazwy _
	Camera mycam;
	public FokusOnBoss cam;

	private float bbb = 0f;
	private float speedonboss = 0.4f;

	public void Start()
	{
		mycam = GetComponent<Camera>();
		cam.changeCamera = false;
	}

	public void Update()
	{

		mycam.orthographicSize = (Screen.height / 100f) / 0.5f;


		if (cam.changeCamera == true)
		{
			if (bbb <= 60)
			{
				bbb = bbb + Time.deltaTime + speedonboss;
			}


			transform.position = Vector3.Lerp(transform.position, Player.position, m_speed ) + new Vector3(bbb , 2, -12);
		}
		else
		{
			if (Player)
			{

				transform.position = Vector3.Lerp(transform.position, Player.position, m_speed) + new Vector3(0, 2, -12);
			}
		}





	}

}
