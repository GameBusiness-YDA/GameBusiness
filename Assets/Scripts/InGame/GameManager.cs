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
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] byte spawnWallNum;

    [SerializeField] int maxCombo;

    [SerializeField] int missComboCount;

    [SerializeField] float countGameTimer;


    /// <summary>
    /// 0:GameClear yet 1:GameClear 2:GameOver 3:finished
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
        if (isGameClear == 3)
        {
            maxCombo = GameObject.Find("ComboManager").GetComponent<ComboManager>().MaxCombo;
            missComboCount = GameObject.Find("ComboManager").GetComponent<ComboManager>().ComboMissCount;
            countGameTimer = GameObject.Find("PlayerManager").GetComponent<GameTimer>().CountGameTimer;
            
            isGameClear = 1;

            SceneManager.LoadScene("Result");
        }
    }

    #region GetSet関数
    public byte SpawnWallNum {
        get { return spawnWallNum; }
        set { spawnWallNum = value; }
    }

    public int MaxCombo {
        get { return maxCombo; }
        set { maxCombo = value; }
    }

    public float CountGameTimer
    {
        get { return countGameTimer; }
        set { countGameTimer = value; }
    }

    /// <summary>
    /// 0:GameClear yet 1:GameClear 2:GameOver 3:finished
    /// </summary>
    public byte IsGameClear
    {
        get { return isGameClear; }
        set { isGameClear = value; }
    }

    public int MissComboCount
    {
        get { return missComboCount; }
        set { missComboCount = value; }
    }

    #endregion

}
