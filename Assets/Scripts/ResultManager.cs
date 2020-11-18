using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    public static ResultManager Instance;


    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ステージセレクトに移行する
    public void OnEnterStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

    //Ingameに移行する
    public void OnEnterRetry()
    {
        SceneManager.LoadScene("InGame");
    }
}
