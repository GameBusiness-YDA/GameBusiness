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

    private void Awake()
    {
        button = GetComponent<Button>();
        s_PlayerManeger = GameObject.Find("PlayerManager");
        playerManager = s_PlayerManeger.GetComponent<PlayerManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteNum = 0;
        spriteState = button.spriteState;
        SetButtonSprite((byte)Random.Range(0, BTN_sprite.Count));
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeButton();
        }
    }

    //引数で指定された画像をボタンのSpriteに差し込む。
    public bool SetButtonSprite(byte i)
    {
        if (i > BTN_sprite.Count)
        {
            Debug.Log("BTN_spriteのリスト外参照が発生しました");
            return false;
        }
        button.GetComponent<Image>().sprite = BTN_sprite[i];
        spriteNum = i;
        return true;
    }

    public void changePlayerModel()
    {
        playerManager.B_Color= (byte)(spriteNum % 3);
        playerManager.B_Sharpe = (byte)(spriteNum / 3);
        playerManager.B_Tag = spriteNum;
        playerManager.ModelChandeFlag = true;
        Debug.Log("PlayerのPrefabを" + (spriteNum % 3) + "カラーを" + ((byte)(spriteNum / 3)) + "に変更しました");
    }


    public void changeButton()
    {
        SetButtonSprite((byte)Random.Range(0, BTN_sprite.Count));
    }
    public void changeButton(byte i)
    {
        SetButtonSprite(i);
    }



}
