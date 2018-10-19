using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    Text text;
    public static Score instance;
	// Use this for initializatio

	void Start () {
        instance = this;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	public void UpdateScore () {

        text = GetComponentInChildren<Text>();
        text.text = "Score: " + gameManager.score.ToString();

		
	}
}
