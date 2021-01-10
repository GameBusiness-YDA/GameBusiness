﻿/*このソースが何か
 * 
 * 作成者		：足立拓海
 * 作成日		：2020/12
 * ソース概要	：ボタンを押すとそのボタンの形にPlayerが変わる。
 * 外部参照変数	：
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectShape : MonoBehaviour
{
    Button button;

    [SerializeField]
    private List<Sprite> BTN_sprite = new List<Sprite>();

    SpriteState spriteState = new SpriteState();

    byte spriteNum;

    GameObject s_PlayerManeger;
    PlayerManager playerManager;

    GameObject s_ButtonManager;
    ButtonManager buttonManager;

    [SerializeField,Range(0,2)] byte buttonIndex;

    private void Awake()
    {
        button = GetComponent<Button>();
        s_PlayerManeger = GameObject.Find("PlayerManager");
        playerManager = s_PlayerManeger.GetComponent<PlayerManager>();

        s_ButtonManager = GameObject.Find("ButtonManager");
        buttonManager = s_ButtonManager.GetComponent<ButtonManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteNum = 0;
        spriteState = button.spriteState;
        SetButtonSprite();
        //SetButtonSprite((byte)Random.Range(0, BTN_sprite.Count));
    }



    // Update is called once per frame
    void Update()
    {
        SetButtonSprite();
        transform.Find("ButtonText").GetComponent<ChangeText>().ChangeTextString = spriteNum.ToString();
    }

    //引数で指定された画像をボタンのSpriteに差し込む。
    public bool SetButtonSprite()
    {
        button.GetComponent<Image>().sprite = buttonManager.GetSprite(buttonIndex);
        spriteNum = buttonManager.GetSpriteNum(buttonIndex);
        return true;
    }

    public void changePlayerModel()
    {
        playerManager.B_Color= (byte)(spriteNum % 3);
        playerManager.B_Sharpe = (byte)(spriteNum / 3);
        playerManager.B_Tag = spriteNum;
        playerManager.ModelChandeFlag = true;
        //Debug.Log("PlayerのPrefabを" + (spriteNum % 3) + "カラーを" + ((byte)(spriteNum / 3)) + "に変更しました");
    }


    /*public void changeButton()
    {
        SetButtonSprite((byte)Random.Range(0, BTN_sprite.Count));
    }
    public void changeButton(byte i)
    {
        SetButtonSprite(i);
    }
    */


}
