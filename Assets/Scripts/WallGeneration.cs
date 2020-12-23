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
            GameObject obj;
            obj = wall[Random.Range(0, wall.Count)];
            //Instantiate(wall, new Vector3(0.0f, 1.0f, 10.0f), Quaternion.identity);
            //Instantiate(wall[Random.Range(0, wall.Count)], new Vector3(0.0f, 1.0f, 10.0f), Quaternion.identity);
            
            //Tag付け用に変更
            Instantiate(obj, new Vector3(8.5f, -3.6f, 10.0f), Quaternion.identity);
            //obj.GetComponent<Renderer>().material = ;
            //obj.tag = Tag();

            obj.layer = 12;

            //タイマーを外部から弄れるように変更
            generatTime = defaultgeneratTime;
            //generatTime = 2.0f;
        }
    }

    /*string Tag()
    {
        string tag;

        switch (b_tag)
        {
            case 0:
                this.tag = "Triangle_Red";
                break;
            case 1:
                this.tag = ("Triangle_Blue");
                break;
            case 2:
                this.tag = ("Triangle_Yellow");
                break;
            case 3:
                this.tag = ("Square_Red");
                break;
            case 4:
                this.tag = ("Square_Blue");
                break;
            case 5:
                this.tag = ("Square_Yellow");
                break;
            case 6:
                this.tag = ("Circle_Red");
                break;
            case 7:
                this.tag = ("Circle_Blue");
                break;
            case 8:
                this.tag = ("Circle_Yellow");
                break;
        }

    
        return this.tag;
    }*/

}
