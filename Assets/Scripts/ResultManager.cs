using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    public static ResultManager Instance;

    long countUpScore;
    long score;


    GameObject s_GameManager;
    GameManager gameManager;


    GameObject s_ChangeText;
    ChangeText changeText;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        s_GameManager = GameObject.Find("GameManager");
        gameManager = s_GameManager.GetComponent<GameManager>();

        s_ChangeText = GameObject.Find("TextScore");
        changeText = s_ChangeText.GetComponent<ChangeText>();

        score = gameManager.GameScore;
        countUpScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(score>=countUpScore)countUpScore+=100;

        changeText.ChangeTextString = "Score : " + countUpScore;
    }

}
