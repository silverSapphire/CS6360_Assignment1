using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    private Light laser;
    private GameObject[] objs;
    private Score score;
    
	// Use this for initialization
	void Start () {
        objs = GameObject.FindGameObjectsWithTag("Trigger");
        laser = GetComponent<Light>();
        laser.enabled = false;
        score = FindObjectOfType<Score>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerStay(Collider other)
    {
        if(GetComponent<Light>().enabled && Input.GetButtonDown("A"))
        {
            score.IncrementScore();
            GetComponent<Light>().enabled = false;
        }

    }
}
