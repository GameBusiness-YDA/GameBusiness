/* スクリプト名 ：WallCeneration.cs
 * 作成者		：小林 凱
 * 作成日		：
 * ソース概要	：壁の生成を行う。
 * 外部参照変数	：s_Color→ChangeColorクラスから色を取得する。
 *                
 * 
 * 更新者		：足立 拓海
 * 更新日		：2021/01/09
 * 更新内容		：壁の生成時に、色形をButtonManagerから指定できるように変更。
 *                タグを共通のクラスから取得するように変更。
 *                クラスを読んで色を変えるように変更。
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGeneration : MonoBehaviour
{
    //追記　List型に変更
    // 生成する壁オブジェクト
    [SerializeField]
    public List<GameObject> wall = new List<GameObject>();

    // 生成までの時間
    float generatTime;

    //追記 タイマーにセットする時間
    float defaultgeneratTime;

    [SerializeField]public byte nextWall;


    TagManager tagManager;
    GameObject s_Tag;

    ChangeColor color;
    GameObject s_Color;

    GameObject s_SEManager;
    SEManager seManager;

    GameObject s_GameManager;
    GameManager gameManager;


    bool countTimeFlg;

    byte wallSpawnNum;

    [SerializeField]
    byte countSpawnNum;


    [SerializeField] float firstWallSpeed;
    [SerializeField] float secondWallSpeed;
    [SerializeField] float thirdWallSpeed;

    /*
    public byte i
    {
        get;
        private set;
    }

    public byte j
    {
        get;
        private set;
    }

    public byte saveI
    {
        get;
        private set;
    }*/

    private void Awake()
    {
    }

    private void Start()
    {

        s_Color = GameObject.Find("PlayerManager");
        color = s_Color.GetComponent<ChangeColor>();

        s_Tag = GameObject.Find("TagManager");
        tagManager = s_Tag.GetComponent<TagManager>();

        s_SEManager = GameObject.Find("SEManager");
        seManager = s_SEManager.GetComponent<SEManager>();

        defaultgeneratTime = 0;

        //Instantiate(wall, new Vector3(0.0f, 2.0f, 0.0f),Quaternion.identity);
        countTimeFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (countTimeFlg == false && defaultgeneratTime == 0)
        {

            s_GameManager = GameObject.Find("GameManager");
            gameManager = s_GameManager.GetComponent<GameManager>();
            generatTime = gameManager.stageData.firstWallSpeed;
            defaultgeneratTime = gameManager.stageData.firstWallSpeed;
            wallSpawnNum = (byte)gameManager.stageData.walls;
            countSpawnNum = 0;
            firstWallSpeed = gameManager.firstWallSpeed;
            secondWallSpeed = gameManager.secondWallSpeed;
            thirdWallSpeed = gameManager.thirdWallSpeed;
            if (defaultgeneratTime != 0) countTimeFlg = true;
        }

        if (countTimeFlg == true)
        {
            generatTime -= Time.deltaTime;
        }
        if (generatTime < 0.0f)
        {
            SpawnNewWall();
        }
    }

    public void SpawnNewWall()
    {
        //nextWall = GameObject.Find("ButtonManager").GetComponent<ButtonManager>().NextWallNumber;

        //GameObject obj;
        //obj = ;

        //Tag付け用に変更
        GameObject obj = Instantiate(wall[nextWall / 3], new Vector3(8.5f, -3.6f, 20.0f), Quaternion.identity);
        obj.transform.Find("default").GetComponent<Renderer>().material = color.GetColor((byte)(nextWall % 3));
        //obj.GetComponent<Renderer>().material = color.GetColor((byte)(nextWall%3));
        obj.tag = tagManager.GetTag(nextWall);

        seManager.WallTagNumber = nextWall;

        if(wallSpawnNum / 3 < GameObject.Find("ComboManager").GetComponent<ComboManager>().ComboCount)
        {
            defaultgeneratTime = secondWallSpeed;
        }
        if ((wallSpawnNum / 3) * 2 < GameObject.Find("ComboManager").GetComponent<ComboManager>().ComboCount)
        {
            defaultgeneratTime = thirdWallSpeed;
        }

        //タイマーを外部から弄れるように変更
        generatTime = defaultgeneratTime;
        //generatTime = 2.0f;

        countTimeFlg = false;
        countSpawnNum++;

        //Debug.Log("WallGeneration.cs");
    }

    public byte NextWall{
        set { nextWall = value; }
        get { return nextWall; }
    }

    public bool CountTimeFlg
    {
        get { return countTimeFlg; }
        set { countTimeFlg = value; }
    }

    /*
    byte SaveNumber(byte num)
    {
        saveI = num;

        return saveI;
    }

    public byte ReturnColorNumber()
    {

        return saveI;

    }
    
    //Playerと共通のタグになるようにTabManagerクラスにしました。
    string GetTag(byte i,byte j)
    {
        string aaa =("");

        if (i == 0)
        {
            if (j == 0)
            {
                aaa = "Circle_Blue";
            }
            else if (j == 1)
            {
                aaa = "Circle_Red";
            }
            else if (j == 2)
            {
                aaa = "Circle_Yellow";
            }
        }
        else if (i == 1)
        {
            if (j == 0)
            {
                aaa = "Square_Blue";
            }
            else if (j == 1)
            {
                aaa = "Square_Red";
            }
            else if (j == 2)
            {
                aaa = "Square_Yellow";
            }
        }
        else
        {
            if (j == 0)
            {
                aaa = "Tryangle_Blue";
            }
            else if (j == 1)
            {
                aaa = "Tryangle_Red";
            }
            else if (j == 2)
            {
                aaa = "Tryangle_Yellow";
            }
        }
        return aaa;
    }*/
}
