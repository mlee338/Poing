using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class PaddleController : NetworkBehaviour { 

    [SerializeField]
    private int paddleSpeed = 10;

    void Start()
    {
        transform.position = new Vector3(20, -110, 0);
    }

    // Start the gps service
    override public void OnStartLocalPlayer()
    {
           
    }

	// Update is called once per frame
	void Update () {
	    if (base.isLocalPlayer)
        {
            float moveVertical = Input.GetAxis("Vertical");
            float moveHorizontal = Input.GetAxis("Horizontal");
            if (moveVertical != 0 || moveHorizontal != 0)
            {
                transform.position = new Vector3(transform.position.x + moveHorizontal * 10 * Time.deltaTime, transform.position.y + moveVertical*10*Time.deltaTime, transform.position.z);
            }

#if UNITY_ANDROID

            /*float deltaX = (GPSManager.singleton.instantLocationX - GPSManager.singleton.originalLocationX) * GPSManager.singleton.modifier;
            float deltaY = (GPSManager.singleton.instantLocationY - GPSManager.singleton.originalLocationY) * GPSManager.singleton.modifier;

            transform.position = new Vector3(20 + deltaX, -110 + deltaY, transform.position.z);*/
#endif
        }
	}
}
