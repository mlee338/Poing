using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class PaddleController : NetworkBehaviour { 

    [SerializeField]
    private int paddleSpeed = 10;



    // Start the gps service
    override public void OnStartLocalPlayer()
    {
           
    }

	// Update is called once per frame
	void Update () {
	    if (base.isLocalPlayer)
        {
            /*float moveVertical = Input.GetAxis("Vertical");
            float moveHorizontal = Input.GetAxis("Horizontal");
            if (moveVertical != 0 || moveHorizontal != 0)
            { 
                Vector3 newPosition = transform.up * moveVertical * (linearSpeed * Time.deltaTime);
                newPosition = transform.position + newPosition;
                transform.position = newPosition;
            }*/
        }
	}
}
