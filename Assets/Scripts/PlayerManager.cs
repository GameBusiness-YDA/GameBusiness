/* スクリプト名 ：PlayerManager.cs
 * 作成者		：足立拓海
 * 作成日		：2020/11/25
 * ソース概要	：Playerを管理する為のスクリプト。
 * 外部参照変数	：
 * 
 */
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

    TagManager tagManager;
    GameObject s_Tag;

    Vector3 playerPosition;
    Quaternion playerRotation;

    Renderer rend;

    byte b_color;
    byte b_sharpe;
    byte b_tag;
    //ボタンを押したかどうか
    bool modelChangeFlg;

    private void Awake()
    {
        s_Color = GameObject.Find("PlayerManager");
        color = s_Color.GetComponent<ChangeColor>();

        s_Model = GameObject.Find("PlayerManager");
        model = s_Model.GetComponent<ChangeModel>();

        s_Tag = GameObject.Find("TagManager");
        tagManager = s_Tag.GetComponent<TagManager>();

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
        if (modelChangeFlg)
        {
            //いまあるPlayerを削除
            Destroy(GameObject.Find("Player"));
            //Playerがあった場所に生成する(リストからPrefabを読み込む、)
            GameObject newObj = Instantiate(model.GetModel(b_sharpe), playerPosition, playerRotation);
            
            //生成したオブジェクトのカラーをPlayerManagerのChangeColorから引き出す。
            newObj.GetComponent<Renderer>().material = color.GetColor(b_color);
            
            //生成したオブジェクトの名前をPlayerにする。
            newObj.name = "Player";

            //生成したオブジェクトのTagをTabManagerからもらう。
            newObj.tag = tagManager.GetTag(b_tag);
            
            //
            modelChangeFlg = false;
        }
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
        set { modelChangeFlg = value; }
    }
    #endregion
}
