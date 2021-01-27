/*スクリプト名  ：ChangeScore.cs
 * 
 * 作成者		：足立拓海
 * 作成日		：2021/01/09
 * ソース概要	：テキストを指定した文字列に変更をする。
                  スコア専用に作成
 * 外部参照変数	：
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScore : ChangeText
{
    [SerializeField]
    GameObject s_gameManager;
    GameManager gameManager;

    [SerializeField]
    long playerScore;

    long countUpScore;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = s_gameManager.GetComponent<GameManager>();

        //Playerのスコアを受け取る。
        //playerScore =gameManager

        countUpScore = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerScore > countUpScore) countUpScore+=10;
        changeTextObject.text = countUpScore.ToString();
    }
}
