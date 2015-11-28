using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class tony : NetworkBehaviour
{

    [SerializeField]
    private int paddleSpeed = 10;

    // Start the gps service
    override public void OnStartLocalPlayer()
    {

    }

    // Update is called once per frame
    void Update()
    {
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

            /* acquire delta */
            float deltaX = (GPSManager.singleton.instantLocationX - GPSManager.singleton.originalLocationX) * GPSManager.singleton.modifier;
            float deltaY = (GPSManager.singleton.instantLocationY - GPSManager.singleton.originalLocationY) * GPSManager.singleton.modifier;

            /* smoother */
            float currentX = transform.position.x;
            float newX = 20 + deltaX;
            if (currentX < newX)
            {
                transform.position += new Vector3(paddleSpeed * Time.deltaTime, 0, 0);
                currentX = transform.position.x;
            }
            else if (currentX > newX)
            {
                transform.position -= new Vector3(paddleSpeed * Time.deltaTime, 0, 0);
                currentX = transform.position.x;
            }
            
        }
    }
}