using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> SetModels = new List<GameObject>();

    //テスト用
    byte i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i = (byte)Random.Range(0, SetModels.Count);
            changeShape(i);

            //Destroy(this);
            Destroy(this.gameObject);
        }
    }

    public void changeShape(byte i)
    {
        //GameObject newObj = new GameObject();

        //生成する
        /*newObj = GameObject.Instantiate(SetModels[i]);
        newObj.transform.position = this.gameObject.transform.position;
        newObj.transform.localScale = this.gameObject.transform.localScale;*/

        //生成する(リストからPrefabを読み込む、)
        Instantiate(SetModels[i], this.gameObject.transform.position,this.gameObject.transform.rotation);

    }
}
