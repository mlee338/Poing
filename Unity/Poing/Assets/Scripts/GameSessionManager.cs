using UnityEngine;
using System.Collections;

public class GameSessionManager : MonoBehaviour {

    [HideInInspector]
    public GameSessionManager singleton;

    void Awake()
    {
        if (singleton != null)
        {
            Debug.LogError("GameSessionManager singleton already exists");
        }
        singleton = this;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
