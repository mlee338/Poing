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


    /*public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        Debug.Log("Adding player");
        GameObject playerSpawnPrefab = base.playerPrefab;
        GameObject player = (GameObject)Instantiate(playerSpawnPrefab, playerSpawnLocation.position, playerSpawnLocation.rotation);
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }*/


}
