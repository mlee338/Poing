using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class CommonCanvasManager : NetworkBehaviour {

    [HideInInspector]
    public static CommonCanvasManager singleton;
    public Canvas networkCanvas;
    public Button serverButton;
    public Button hostButton;
    public Button clientButton;
    public Button readyButton;

    void Awake ()
    {
        if (singleton != null)
        {
            Debug.LogError("CommonCanvasManager singleton already exists");
        }
        singleton = this;   
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartServerButtonCallback()
    {
        NetworkManager.singleton.StartServer();
        disableCanvas();
        readyButton.gameObject.SetActive(false);
    }

    public void StartHostButtonCallback()
    {
        //Networ
        NetworkManager.singleton.StartHost();
        disableCanvas();
    }

    public void StartClientButtonCallback()
    {
        NetworkManager.singleton.networkAddress = "131.181.9.176";
        NetworkManager.singleton.StartClient();
        disableCanvas();
    }

    public void disableCanvas()
    {
        if (networkCanvas != null)
        {
            //networkCanvas.enabled = false;
            serverButton.gameObject.SetActive(false);
            hostButton.gameObject.SetActive(false);
            clientButton.gameObject.SetActive(false);
        }
    }

    public void clientReadyCallback()
    {
        //Debug.LogError("Called");
        if (NetworkClient.active && !ClientScene.ready)
        {
            ClientScene.Ready(NetworkManager.singleton.client.connection);
            if (ClientScene.localPlayers.Count == 0)
            {
                ClientScene.AddPlayer(0);
            }
            readyButton.gameObject.SetActive(false);
        }
    }
}
