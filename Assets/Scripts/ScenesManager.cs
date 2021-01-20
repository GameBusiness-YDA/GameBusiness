/*スクリプト名    ：ScenesManager.cs
 *作成者          ：小林凱
 *作成日          ：2021/01/20
 *ソース概要
 *　シーン遷移を行うボタン等にこのスクリプトをアタッチし、
 *　ボタンのタグを遷移したいSceneの名前にすればそのSceneに遷移する。
 *外部参照変数
 *　無し
 */
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{
    
    /// <summary>
    /// ボタン押下時の処理。このスクリプトがアタッチされているオブジェクトのタグに
    /// 準じたSceneへ遷移をする。
    /// </summary>
    public void OnClick()
    {

        switch (this.gameObject.tag)
        {
            
            // タイトルシーンへの遷移
            case "Title":
                SceneManager.LoadScene("Title");
                Debug.Log(this.gameObject.tag + "に遷移します。");
                break;

            // ステージセレクトシーンへの遷移
            case "StageSelect":
                SceneManager.LoadScene("StageSelect");
                Debug.Log(this.gameObject.tag + "に遷移します。");
                break;
            
            // ゲームシーンへの遷移
            case "InGame":
                SceneManager.LoadScene("InGame");
                Debug.Log(this.gameObject.tag + "に遷移します。");
                break;

            // リザルトシーンへの遷移
            case "Result":
                SceneManager.LoadScene("Result");
                Debug.Log(this.gameObject.tag + "に遷移します。");
                break;

            // タグ未設定もしくは非対応タグの設定時
            default:
                Debug.Log("遷移先のSceneが指定されていません。" +
                    "タグで遷移先のSceneを指定してください。現在の指定Scene：" + 
                    this.gameObject.tag);
                break;

        }

    }

}
