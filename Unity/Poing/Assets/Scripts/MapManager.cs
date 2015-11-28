using UnityEngine;
using System.Collections;

public class MapManager : MonoBehaviour {

    public MapManager singleton;

    void Awake()
    {
        if (singleton != null)
        {
            Debug.LogError("MapManager singleton already exists");
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
