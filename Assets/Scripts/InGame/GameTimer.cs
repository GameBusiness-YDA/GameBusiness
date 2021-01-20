/* スクリプト名 ：GameTimer.cs
 * 作成者		：足立 拓海
 * 作成日		：20202/01/13
 * ソース概要	：ゲーム内の時間をはかる。
 * 外部参照変数	：changeText→GameTimerTextにアタッチされたChangeTextを書き換えるために使用。
 *                
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    GameObject s_gameTimerText;
    ChangeText changeText;

    float countGameTime;

    // Start is called before the first frame update
    void Start()
    {
        s_gameTimerText = GameObject.Find("GameTimerText");
        changeText = s_gameTimerText.GetComponent<ChangeText>();
        countGameTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countGameTime += Time.deltaTime;
        countUpGameTimer();
    }

    void countUpGameTimer()
    {
        byte mm = (byte)(countGameTime / 60);
        byte ss = (byte)(countGameTime % 60);
        byte ms = (byte)((countGameTime - Mathf.Floor(countGameTime)) * 100);

        changeText.ChangeTextString = mm.ToString("D2") + ":" + ss.ToString("D2") + ":" + ms.ToString("D2");
    }

    public float CountGameTimer
    {
        get { return countGameTime; }
    }
}
