using UnityEngine;
using System.Collections;

public class GPSManager : MonoBehaviour {

    [HideInInspector]
    public static GPSManager singleton;

    private float originalLocationX = 0;
    private float originalLocationY = 0;
    [HideInInspector]
    public float instantLocationX = 0;
    [HideInInspector]
    public float instantLocationY = 0;
    private float modifier = 10000;

    void Awake()
    {
        if (singleton != null)
        {
            Debug.LogError("GPSManager already exists!");
        }
        singleton = this;
    }

    IEnumerator Start()
    {
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield break;

        // Start service before querying location
        Input.location.Start(1.0f, 1.0f);

        // Wait until service initializes
        int maxWait = 30;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            Debug.LogError("Timed out");
            PlayerCanvasManager.singleton.debugWindow.text = "Timed Out";
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.LogError("Unable to determine device location");
            PlayerCanvasManager.singleton.debugWindow.text = "Unable to determine device location";
            yield break;
        }
        else
        {
            // Access granted and location value could be retrieved
            Debug.Log("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
            PlayerCanvasManager.singleton.debugWindow.text = "Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp;
            originalLocationX = Input.location.lastData.latitude;
            originalLocationY = Input.location.lastData.longitude;
        }

        // Stop service if there is no need to query location updates continuously
        // Input.location.Stop();
    }

    void Update()
    {
        instantLocationX = Input.location.lastData.latitude;
        instantLocationY = Input.location.lastData.longitude;
        float deltaX = (instantLocationX - originalLocationX) * modifier;
        float deltaY = (instantLocationY - originalLocationY) * modifier;
        Vector3 displacement = new Vector3(deltaX, 0.0f, deltaY);

        PlayerCanvasManager.singleton.debugWindow.text = "delta: " + deltaX + ", " + deltaY + " start: " + originalLocationX + ", " + originalLocationY + " now: " + instantLocationX + ", " + instantLocationY;
    }

}
