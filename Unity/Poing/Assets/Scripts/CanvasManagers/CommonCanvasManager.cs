using UnityEngine;
using System.Collections;

public class CommonCanvasManager : MonoBehaviour {

    [HideInInspector]
    public CommonCanvasManager singleton;

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
}
