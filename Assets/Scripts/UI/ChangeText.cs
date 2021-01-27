/*スクリプト名  ：ChangeText.cs
 * 
 * 作成者		：足立拓海
 * 作成日		：2021/01/09
 * ソース概要	：テキストを指定した文字列に変更をする。
 * 外部参照変数	：
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{

    public GameObject textObject;

    protected Text changeTextObject;

    protected string changeTextString;

    // Start is called before the first frame update
    void Start()
    {
        changeTextObject = textObject.GetComponent<Text>();

        string changeTextString = "";
    }

    // Update is called once per frame
    void Update()
    {
        changeTextObject.text = changeTextString;
    }

    public string ChangeTextString
    {
        get { return changeTextString; }
        set { changeTextString = value; }
    }
}
