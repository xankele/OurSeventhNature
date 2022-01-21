using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform Player;
	public Transform Boss;
	public float m_speed = 0.1f; //nazwy _
	Camera mycam;
	public FokusOnBoss cam;

	private Vector3 aaa;
	private float bbb = 0f;
	private float ccc;
	private bool tak = false;

	public void Start()
	{
		mycam = GetComponent<Camera>();
		aaa = Boss.position;
		cam.changeCamera = false;
	}

	public void Update()
	{

		mycam.orthographicSize = (Screen.height / 100f) / 0.5f;

        if (Boss)
        {
			if (cam.changeCamera == true)
			{
				Debug.Log("tak: " + tak + " bbb: " + bbb + " ccc: " + ccc);
				if (bbb <= 60 && tak == false)
				{
					bbb = bbb + 0.1f;
				}
				else if (bbb > 60 && ccc < 400)
				{
					ccc = ccc + 1f;
					tak = true;
					//bbb = bbb - 0.1f;
				}
				else if (ccc >= 60 && tak == true && bbb > 0)
				{
					bbb = bbb - 0.1f;
				}

				transform.position = Vector3.Lerp(transform.position, Player.position, m_speed) + new Vector3(bbb, 2, -12);
			}
			else
			{
				if (Player)
				{

					transform.position = Vector3.Lerp(transform.position, Player.position, m_speed) + new Vector3(0, 2, -12);
				}
			}
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
