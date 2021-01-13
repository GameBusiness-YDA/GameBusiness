/* スクリプト名 ：GameManager.cs
 * 作成者		：足立 拓海
 * 作成日		：20202/01/13
 * ソース概要	：ゲーム内の情報を持つ。
 * 外部参照変数	：
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] byte spawnWallNum;

    [SerializeField] byte maxCombo;

    [SerializeField] float countGameTimer;


    /// <summary>
    /// 0:GameClear yet 1:GameClear 2:GameOver
    /// </summary>
    byte isGameClear;

    private void Awake()
    {
        spawnWallNum = 0;
        maxCombo = 0;
        countGameTimer = 0;
        isGameClear = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Sceneが遷移しても破棄されないようにする。
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    #region GetSet関数
    public byte SpawnWallNum {
        get { return spawnWallNum; }
        set { spawnWallNum = value; }
    }

    public byte MaxCombo {
        get { return maxCombo; }
        set { maxCombo = value; }
    }

    public float CountGameTimer
    {
        get { return countGameTimer; }
        set { countGameTimer = value; }
    } 

    public byte IsGameClear
    {
        get { return isGameClear; }
        set { isGameClear = value; }
    }

    #endregion

}
