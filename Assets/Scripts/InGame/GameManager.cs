/* スクリプト名 ：GameManager.cs
 * 作成者		：足立 拓海
 * 作成日		：20202/01/13
 * 更新者       ：小林凱
 * 更新日       ：2021/01/27
 * 更新者       ：足立拓海
 * 更新日       ：2021/02/07
 * ソース概要	：ゲーム内の情報を持つ。
 * 外部参照変数	：
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] byte stageNum;

    [SerializeField] int spawnWallNum;

    [SerializeField] int maxCombo;

    [SerializeField] int missComboCount;

    [SerializeField] float countGameTimer;

    [SerializeField] long gameScore;

    [SerializeField]
    private List<StageData> stageDataList = new List<StageData>();

    [SerializeField]
    private StageData playStageData;

    [SerializeField] public float firstWallSpeed;
    [SerializeField] public float secondWallSpeed;
    [SerializeField] public float thirdWallSpeed;

    public int listNum
    {
        get;
        private set;
    }

    private void Awake()
    {

        maxCombo = 0;
        countGameTimer = 0;
        listNum = -1;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Sceneが遷移しても破棄されないようにする。
        DontDestroyOnLoad(this);
    }

    private void FixedUpdate()
    {
        playStageData = stageDataList[stageNum];
        spawnWallNum = playStageData.walls;
        firstWallSpeed = playStageData.firstWallSpeed;
        secondWallSpeed = playStageData.secondWallSpeed;
        thirdWallSpeed = playStageData.thirdWallSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //listNum = GameObject.Find("StageSelectButton").GetComponent<StageStart>().ReturnStageNum();
        if (listNum > -1)
        {
            playStageData = stageDataList[listNum];
            Debug.Log(playStageData);
        }
        try
        {
            if (GameObject.Find("ComboManager").GetComponent<ComboManager>().ComboCount >= spawnWallNum)
            {
                maxCombo = GameObject.Find("ComboManager").GetComponent<ComboManager>().MaxCombo;
                missComboCount = GameObject.Find("ComboManager").GetComponent<ComboManager>().ComboMissCount;
                countGameTimer = GameObject.Find("PlayerManager").GetComponent<GameTimer>().CountGameTimer;

                calculationGameScore();

                SceneManager.LoadScene("Result");
            }
        }
        catch
        {
            Debug.Log("ComboManagerがNullReferenceかも");
        }
    }

    //GameのScoreを計算
    void calculationGameScore()
    {
        gameScore = maxCombo * 10000 - missComboCount * 1000 - (long)(((int)countGameTimer) / 10);
    }

    private void ResetStageData()
    {
        stageNum = 0;
    }


    #region GetSet関数
    public StageData stageData
    {
        get { return playStageData; }
    }

    public byte StageNum
    {
        get { return stageNum; }
        set { stageNum = value; }
    }

    public int SpawnWallNum
    {
        get { return spawnWallNum; }
        set { spawnWallNum = value; }
    }

    public int MaxCombo
    {
        get { return maxCombo; }
        set { maxCombo = value; }
    }

    public float CountGameTimer
    {
        get { return countGameTimer; }
        set { countGameTimer = value; }
    }

    public int MissComboCount
    {
        get { return missComboCount; }
        set { missComboCount = value; }
    }

    public long GameScore
    {
        get { return gameScore; }
    }

    #endregion

}
