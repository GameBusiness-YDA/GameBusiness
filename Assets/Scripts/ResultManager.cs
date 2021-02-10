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

    [SerializeField] AudioClip doramu;
    [SerializeField] AudioClip jann;

    bool finishScoreCountUpFlg;
    bool startScoreCountUpFlg;

    AudioSource audio;

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

        audio = GetComponent<AudioSource>();
        finishScoreCountUpFlg = false;
        startScoreCountUpFlg = false;

        score = gameManager.GameScore;
        countUpScore = 0;
        audio.PlayOneShot(doramu);
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= countUpScore)
        {
            countUpScore += 100;

            if (audio.time >= 1f)
            {
                audio.time = 0.4f;
            }
        }
        if (score <= countUpScore && !finishScoreCountUpFlg)
        {
            audio.Stop();
            audio.PlayOneShot(jann);
            finishScoreCountUpFlg = true;
        }

        changeText.ChangeTextString = "Score : " + countUpScore;
    }

}
