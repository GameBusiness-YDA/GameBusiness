using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboText : MonoBehaviour
{
    public static ResultTextChanger Instance;

    public Text comboText;  //リザルト結果
    private string planeText = "combo!";  //ゲームオーバー時表示文

    private int combo;     //スコア取得用


    // Start is called before the first frame update
    void Start()
    {
        combo = ComboManager.Instance.GetCombo();
    }

    // Update is called once per frame
    void Update()
    {
        combo= ComboManager.Instance.GetCombo();
        //combo++;
        Debug.Log("<color=red>コンボ："+combo.ToString()+"</color>");
        if(combo > 0)comboText.text = combo.ToString();
    }
}
