/*スクリプト名：StageStart
 *作成者      ：小林凱
 *作成日      ：2021/01/13
 *ソース概要
 *　ボタンを押したときにStageDataの値をGameManagerに渡す為の処理
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageStart : MonoBehaviour
{

    public StageData stageData;

    public int stageNum
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
    }

    /// <summary>
    /// ボタン押下でステージデータを格納
    /// </summary>
    public void OnClick()
    {
        ShowData();
        stageNum = stageData.stageNum;
        walls = stageData.walls;
        firstWallSpeed = stageData.firstWallSpeed;
        secondWallSpeed = stageData.secondWallSpeed;
        thirdWallSpeed = stageData.thirdWallSpeed;
    }

    /// <summary>
    /// ステージデータ内のデータを見るための関数
    /// </summary>
    void ShowData()
    {
        Debug.Log("ステージ" + stageData.stageNum + "のデータです。");
    }

}
