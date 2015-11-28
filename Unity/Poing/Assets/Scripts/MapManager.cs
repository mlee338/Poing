using UnityEngine;
using System.Collections;

public class MapManager : MonoBehaviour {

    [HideInInspector]
    public MapManager singleton;

    public Vector2 ArenaCentre = new Vector2((float) -27.477721, (float) 153.028414);
    public Vector2 RotationOffset;

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
