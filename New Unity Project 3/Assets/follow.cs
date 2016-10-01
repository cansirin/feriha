using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public Transform player = null;
	public float cameraHeight = 77.0f;
	private Transform cam = null;


	public void Start()
	{
		cam = transform;
	}
	public void Update()
	{
		Vector3 pos = player.position;
		pos.y = cameraHeight;
		pos.x = pos.x - 31;
		pos.z = pos.z - 37;
		cam.position = pos;
	}
}
