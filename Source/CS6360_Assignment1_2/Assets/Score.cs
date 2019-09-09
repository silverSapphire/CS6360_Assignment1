using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private GameObject[] objs;
    private float waitTime = 3.0f;
    private float timer = 0.0f;
    private int laser = 0;
    public int score = 0;

    public Text txt;
    
    // Use this for initialization
    void Start () {
        objs = GameObject.FindGameObjectsWithTag("Trigger");
        Debug.Log(objs.Length + " lights found!");
        objs[laser].GetComponent<Light>().enabled = true;

        txt = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Start"))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;

            #else
                Application.Quit();

            #endif
        }

        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            timer -= waitTime;
            int i = Random.Range(0, objs.Length);
            if(laser == i)
            {
                i = (i + 1) % objs.Length;
            }
            objs[laser].GetComponent<Light>().enabled = false;
            laser = i;
            objs[i].GetComponent<Light>().enabled = true;
        }


    }

    public void IncrementScore()
    {
        score++;

        txt.text = "Score: " + score.ToString();
        Debug.Log("Score: " + score);

        timer = 0;
        int i = Random.Range(0, objs.Length);
        if (laser == i)
        {
            i = (i + 1) % objs.Length;
        }
        objs[laser].GetComponent<Light>().enabled = false;
        laser = i;
        objs[i].GetComponent<Light>().enabled = true;
    }
}
