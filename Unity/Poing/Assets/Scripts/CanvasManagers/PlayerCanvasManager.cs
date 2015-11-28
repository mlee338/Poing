using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCanvasManager : MonoBehaviour {

    [HideInInspector]
    public static PlayerCanvasManager singleton;
    public Text debugWindow;

    void Awake()
    {
        if (singleton != null)
        {
            Debug.LogError("PlayerCanvasManager singleton already exists");
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
