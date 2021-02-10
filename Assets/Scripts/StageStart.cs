/*スクリプト名：StageStart
 *作成者      ：小林凱
 *作成日      ：2021/01/13
 *ソース概要
 *　ボタンを押したときにStageDataの値をGameManagerに渡す為の処理
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageStart : MonoBehaviour
{

    //public StageData stageData;

    public int stageNum
    {
        get;
        private set;
    }

    /*public int stageNum
    {
        get;
        private set;
    }
    public int walls
    {
        get;
        private set;
    }
    public float firstWallSpeed
    {
        get;
        private set;
    }
    public float secondWallSpeed
    {
        get;
        private set;
    }
    public float thirdWallSpeed
    {
        get;
        private set;
    }*/

    /// <summary>
    /// ボタン押下でステージデータを格納
    /// </summary>
    public void OnClick()
    {

        switch (this.gameObject.tag)
        {
            case "Stage1":
                stageNum = 0;
                break;
            case "Stage2":
                stageNum = 1;
                break;
            case "Stage3":
                stageNum = 2;
                break;
            case "Stage4":
                stageNum = 3;
                break;
            case "Stage5":
                stageNum = 4;
                break;
            case "Stage6":
                stageNum = 5;
                break;
            case "Stage7":
                stageNum = 6;
                break;
            case "Stage8":
                stageNum = 7;
                break;
            case "Stage9":
                stageNum = 8;
                break;
            case "Stage10":
                stageNum = 9;
                break;

        }

        GameObject.Find("GameManager").GetComponent<GameManager>().StageNum = (byte)stageNum;

        //追記　Onclickを押したらInGameに画面遷移する
        SceneManager.LoadScene("InGame");

        /*ShowData();
        stageNum = stageData.stageNum;
        walls = stageData.walls;
        firstWallSpeed = stageData.firstWallSpeed;
        secondWallSpeed = stageData.secondWallSpeed;
        thirdWallSpeed = stageData.thirdWallSpeed;*/

    }

    /*/// <summary>
    /// ステージデータ内のデータを見るための関数
    /// </summary>
    void ShowData()
    {
        Debug.Log("ステージ" + stageData.stageNum + "のデータです。");
    }


    /// <summary>
    /// ステージナンバーを返す
    /// </summary>
    /// <returns>ステージナンバー</returns>
    public int ReturnStageNum()
    {
        return stageNum;
    }*/

}
