using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGeneration : MonoBehaviour
{
    //追記　List型に変更
    // 生成する壁オブジェクト
    [SerializeField]
    public List<GameObject> wall = new List<GameObject>();

    /*[SerializeField]
    public GameObject wall;*/

    // 生成までの時間
    float generatTime;

    public byte i
    {
        get;
        private set;
    }

    public byte j
    {
        get;
        private set;
    }

    public byte saveI
    {
        get;
        private set;
    }


    //追記 タイマーにセットする時間
    [SerializeField] float defaultgeneratTime;

    private void Awake()
    {
        generatTime = defaultgeneratTime;
    }

    private void Start()
    {
        //Instantiate(wall, new Vector3(0.0f, 2.0f, 0.0f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        generatTime -= Time.deltaTime;

        if (generatTime < 0.0f)
        {

            i = (byte)Random.Range(0, wall.Count);
            SaveNumber(i);
            //j = 1;

            //Instantiate(wall, new Vector3(0.0f, 1.0f, 10.0f), Quaternion.identity);
            Instantiate(wall[i], new Vector3(8.5f, -3.6f, 10.0f), Quaternion.identity);
            generatTime = defaultgeneratTime;
            //generatTime = 2.0f;
        }
    }

    byte SaveNumber(byte num)
    {
        saveI = num;

        return saveI;
    }

    public byte ReturnColorNumber()
    {

        return saveI;

    }

}
