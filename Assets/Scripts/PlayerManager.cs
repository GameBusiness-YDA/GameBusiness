using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    bool ChangePlayer;
    byte PlayerState;

    ChangeColor color;
    GameObject s_Color;

    ChangeModel model;
    GameObject s_Model;

    Vector3 playerPosition;
    Quaternion playerRotation;

    Renderer rend;

    byte b_color;
    byte b_sharpe;
    byte b_tag;
    //ボタンを押したかどうか
    bool changed;

    private void Awake()
    {
        s_Color = GameObject.Find("PlayerManager");
        color = s_Color.GetComponent<ChangeColor>();

        s_Model = GameObject.Find("PlayerManager");
        model = s_Model.GetComponent<ChangeModel>();

        rend = GetComponent<Renderer>();

    }

    // Start is called before the first frame update
    void Start()
    {
        ChangePlayer = false;
        PlayerState = 0;
        playerPosition = GameObject.Find("Player").transform.position;
        playerRotation = GameObject.Find("Player").transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (changed)
        {
            Destroy(GameObject.Find("Player"));
            //生成する(リストからPrefabを読み込む、)
            GameObject newObj = Instantiate(model.GetModel(b_sharpe), playerPosition, playerRotation);
            newObj.GetComponent<Renderer>().material = color.GetColor(b_color);
            newObj.name = ("Player");
            newObj.tag = Tag();
            changed = false;
        }
    }

    string Tag()
    {
        string tag;

        switch (b_tag)
        {
            case 0:
                this.tag = "Triangle_Red";
                break;
            case 1:
                this.tag = ("Triangle_Blue");
                break;
            case 2:
                this.tag = ("Triangle_Yellow");
                break;
            case 3:
                this.tag = ("Square_Red");
                break;
            case 4:
                this.tag = ("Square_Blue");
                break;
            case 5:
                this.tag = ("Square_Yellow");
                break;
            case 6:
                this.tag = ("Circle_Red");
                break;
            case 7:
                this.tag = ("Circle_Blue");
                break;
            case 8:
                this.tag = ("Circle_Yellow");
                break;
        }


        return this.tag;
    }


    #region GetSet関数
    public byte B_Color
    {
        get { return b_color; }
        set { b_color = value; }
    }

    public byte B_Sharpe
    {
        get { return b_sharpe; }
        set { b_sharpe = value; }
    }

    public byte B_Tag
    {
        get { return b_tag; }
        set { b_tag = value; }
    }

    public bool ModelChandeFlag
    {
        set { changed = value; }
    }
    #endregion
}
