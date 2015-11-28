using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Vector2 PositionOffset;
    public float RotationOffset;

    public float CameraFOV;

    public Camera cameraObject;

	// Use this for initialization
	void Start () {
        cameraObject.transform.position = new Vector3(PositionOffset.x, PositionOffset.y, cameraObject.transform.position.z);
        /*cameraObject.transform.rotation = new Quaternion(cameraObject.transform.rotation.x,
                                                cameraObject.transform.rotation.y,
                                                cameraObject.transform.rotation.z + (int)RotationOffset,
                                                1);*/

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
