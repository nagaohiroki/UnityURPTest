using UnityEngine;
public class CameraHandle : MonoBehaviour
{
	[SerializeField] float speed = 100.0f;
	Vector3 angle;
	void Update()
	{
		angle.y -= Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		angle.x += Input.GetAxis("Vertical") * speed * Time.deltaTime;
		transform.eulerAngles = angle;
	}
}
