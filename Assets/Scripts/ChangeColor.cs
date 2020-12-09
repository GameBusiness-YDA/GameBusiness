using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    [SerializeField]
    List<Material> setMaterials = new List<Material>();

    [SerializeField]
    GameObject wg;

    Renderer rend;

    public byte i
    {
        get;
        private set;
    }

    //テスト用の変数
    public byte j
    {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Awake()
    {

        i = FindObjectOfType<WallGeneration>().ReturnColorNumber();

        //生成時に、起動
        j = (byte)Random.Range(0,setMaterials.Count);


        if (i == 0)
        {
            if (j == 0)
            {
                this.gameObject.tag = "Circle_Blue";
            }
            else if (j == 1)
            {
                this.gameObject.tag = "Circle_Red";
            }
            else if (j == 2)
            {
                this.gameObject.tag = "Circle_Yellow";
            }
        }
        else if (i == 1)
        {
            if (j == 0)
            {
                this.gameObject.tag = "Square_Blue";
            }
            else if (j == 1)
            {
                this.gameObject.tag = "Square_Yellow";
            }
            else if (j == 2)
            {
                this.gameObject.tag = "Square_Red";
            }
        }
        else if (i == 2)
        {
            if (j == 0)
            {
                this.gameObject.tag = "Tryangl_Blue";
            }
            else if (j == 1)
            {
                this.gameObject.tag = "Tryangle_Red";
            }
            else if (j == 2)
            {
                this.gameObject.tag = "Tryangle_Yellow";
            }
        }

        rend = GetComponent<Renderer>();

        changeColors(j);

    }

    /// <summary>
    /// setMaterialsにセットされたマテリアルに変更をする　
    /// </summary>
    /// <param name="i"></param>
    public void changeColors(byte j)
    {
        rend.material = setMaterials[j];
    }

}
