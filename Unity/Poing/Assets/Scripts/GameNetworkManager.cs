using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class GameNetworkManager : NetworkManager {



	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
        //conn.isReady = true;
        //ClientScene.Ready(conn);

        
    }

    public override void OnClientSceneChanged(NetworkConnection conn)
    {
        base.OnClientSceneChanged(conn);

        //conn.isReady = true;
        //ClientScene.Ready(conn);
        Debug.LogError("Client Ready " + conn.isReady);
    }

    /*public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        Debug.Log("Adding player");
        GameObject playerSpawnPrefab = base.playerPrefab;
        GameObject player = (GameObject)Instantiate(playerSpawnPrefab, playerSpawnLocation.position, playerSpawnLocation.rotation);
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }*/


}
