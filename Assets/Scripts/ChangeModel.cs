using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> setModels = new List<GameObject>();

    //テスト用
    byte i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    /*public void changeShape(byte i)
    {
        //GameObject newObj = new GameObject();

        //生成する
        /*newObj = GameObject.Instantiate(SetModels[i]);
        newObj.transform.position = this.gameObject.transform.position;
        newObj.transform.localScale = this.gameObject.transform.localScale;

        //生成する(リストからPrefabを読み込む、)
        GameObject newObj = Instantiate(setModels[i], this.gameObject.transform.position,this.gameObject.transform.rotation);
        newObj.name = ("Player");
        newObj.tag = ("Player");


        Destroy(this.gameObject);
    }*/

    public GameObject GetModel(byte i)
    {
        return setModels[i];
    }
}
