using UnityEngine;

//To make all instances of a script execute in edit mode
[ExecuteInEditMode]

public class LookTarget : MonoBehaviour
{
	public Transform target;

	private void Update()
	{
 		//target - object to point towards
		//Rotates the transform so the forward vector points at /target/'s current position
		transform.LookAt(target);
	}
}