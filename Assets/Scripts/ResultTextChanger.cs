using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextChanger : MonoBehaviour
{
    public static ResultTextChanger Instance;

    public Text resultText;  //リザルト結果
    public Text scoreText;  //スコア

    private string clearText= "STAGE COMPLETE";  //クリア時表示文
    private string gameOverText= "GAME OVER";  //ゲームオーバー時表示文

    private int clearFlg; //クリアしたかしてないか 0:ゲームオーバー 1:クリア
    private int score;     //スコア取得用


    void Awake()
    {
        Instance = this;
        
        //Ingameからスコアとリザルト結果判定フラグ持ってくる
        //InGameManager.Instance.GetResult();
        clearFlg = 0;

        //score = InGameManager.Instance.GetScore();
        score = 5000;

    }

    // Start is called before the first frame update
    void Start()
    {
        clearFlg = 0;
        dispText();

    }

    // Update is called once per frame
    void Update()
    {
        ;
    }

    void dispText()
    {
        if (clearFlg == 1)
        {
            resultText.text = clearText;
        }
        else
        {
            resultText.text = gameOverText;
        }

        scoreText.text = "Score:" + score.ToString();
    }
}
