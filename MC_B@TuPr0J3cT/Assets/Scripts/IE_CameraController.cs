
using UnityEngine;

public class IE_CameraController : MonoBehaviour
{


    private float f_InputX;
    private float f_InputY;

    private float f_SmoothedX;
    private float f_SmoothedY;

    private float f_RefX;
    private float f_RefY;


    public Vector2 v2_Sensitivity;
    public float f_SmoothTime;

	private Quaternion q_This;
	private Quaternion q_Player;
	public Transform t_Player;

	void Awake()
	{
		q_This = transform.localRotation;
		q_Player = t_Player.localRotation;
	}
    void Update()
    {

        f_InputX += Input.GetAxis("Mouse X") * v2_Sensitivity.x;
        f_InputY -= Input.GetAxis("Mouse Y") * v2_Sensitivity.y;

		// f_InputY'i Limitle. "Clamp"

        f_SmoothedX = Mathf.SmoothDamp(f_SmoothedX, f_InputX, ref f_RefX, f_SmoothTime);
        f_SmoothedY = Mathf.SmoothDamp(f_SmoothedY, f_InputY, ref f_RefY, f_SmoothTime);

        Quaternion q_X = Quaternion.AngleAxis(f_SmoothedX, Vector3.up);
        Quaternion q_Y = Quaternion.AngleAxis(f_SmoothedY, Vector3.right);

		t_Player.localRotation = q_Player * q_X;
        transform.localRotation = q_This * q_Y;
    }


}
