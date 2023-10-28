using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreWindow : MonoBehaviour
{
    private Text scoreText;
    private void Awake()
    {
        scoreText = GameObject.Find("scoreText").GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = GameHandler.GetScore().ToString();
    }
}
