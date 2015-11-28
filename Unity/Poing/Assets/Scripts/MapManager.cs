using UnityEngine;
using System.Collections;

public class MapManager : MonoBehaviour {

    [HideInInspector]
    public MapManager singleton;

    public Vector2 ArenaCentre = new Vector2((float) -27.477721, (float) 153.028414);

    public GameObject GameMap;

    void Awake()
    {
        if (singleton != null)
        {
            Debug.LogError("MapManager singleton already exists");
        }
        singleton = this;
    }

    void Start () {
	}
	
	void Update () {
	}
}
