using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfacePoints : MonoBehaviour {

    public Text points;
   

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        points.text = string.Format("Points: {0}", GameManager.point);
       
    }
}
