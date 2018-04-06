
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class IE_PlayerController : MonoBehaviour {

	public float f_Speed;
	public float f_JumpSpeed;
	public float f_Gravity;
	private Vector3 v3_MoveDirection = Vector3.zero;
	public CharacterController cc_This;

	void Update()
	{
		
		// Input'u v3_MoveDirection'a sakla. "Horizontal" ve "Vertical"
		// Scripting Reference CharacterController Move


		cc_This.Move(v3_MoveDirection * Time.deltaTime);

	}

}
