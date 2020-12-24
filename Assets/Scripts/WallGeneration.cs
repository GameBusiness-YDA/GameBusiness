using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGeneration : MonoBehaviour
{
    //追記　List型に変更
    // 生成する壁オブジェクト
    [SerializeField]
    public List<GameObject> wall = new List<GameObject>();

    /*[SerializeField]
    public GameObject wall;*/

    // 生成までの時間
    float generatTime;

    //追記 タイマーにセットする時間
    [SerializeField] float defaultgeneratTime;

    [SerializeField]public byte nextWall;


    ChangeColor color;
    GameObject s_Color;

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
    }

    private void Awake()
    {
        generatTime = defaultgeneratTime;
    }

    private void Start()
    {

        s_Color = GameObject.Find("PlayerManager");
        color = s_Color.GetComponent<ChangeColor>();

        //Instantiate(wall, new Vector3(0.0f, 2.0f, 0.0f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        generatTime -= Time.deltaTime;

        if (generatTime < 0.0f)
        {
            i = (byte)Random.Range(0, wall.Count);
            SaveNumber((byte)(nextWall%3));
            //SaveNumber(i);

            GameObject obj;
            obj = wall[nextWall/3];
            
            //Tag付け用に変更
            Instantiate(obj, new Vector3(8.5f, -3.6f, 10.0f), Quaternion.identity);
            //obj.GetComponent<Renderer>().material = color.GetColor((byte)(nextWall%3));
           // obj.tag = GetTag((byte)(nextWall / 3), (byte)(nextWall % 3));
            obj.layer = 12;

            //タイマーを外部から弄れるように変更
            generatTime = defaultgeneratTime;
            //generatTime = 2.0f;
        }
    }

    public byte NextWall{
        set { nextWall = value; }
        get { return nextWall; }
    }

    byte SaveNumber(byte num)
    {
        saveI = num;

        return saveI;
    }

    public byte ReturnColorNumber()
    {

        return saveI;

    }

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
    }
}
