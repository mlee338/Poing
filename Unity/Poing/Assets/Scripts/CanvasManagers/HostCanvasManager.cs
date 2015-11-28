using UnityEngine;
using System.Collections;

public class HostCanvasManager : MonoBehaviour {

    [HideInInspector]
    public HostCanvasManager singleton;

    void Awake()
    {
        if (singleton != null)
        {
            Debug.LogError("HostCanvasManager singleton already exists");
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
