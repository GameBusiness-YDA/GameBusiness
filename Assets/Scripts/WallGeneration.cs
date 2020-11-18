using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGeneration : MonoBehaviour
{
    // 生成する壁オブジェクト
    [SerializeField]
    public GameObject wall;

    // 生成までの時間
    float generatTime;

    private void Awake()
    {
        generatTime = 2.0f;
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
            Instantiate(wall, new Vector3(0.0f, 1.0f, 10.0f), Quaternion.identity);
            generatTime = 2.0f;
        }
    }
}
