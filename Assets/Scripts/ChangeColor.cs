using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    [SerializeField]
    List<Material> setMaterials = new List<Material>();

    Renderer rend;

    //テスト用の変数
    byte i;

    // Start is called before the first frame update
    void Awake()
    {
        //生成時に、起動
        i = (byte)Random.Range(0,setMaterials.Count);

        rend = GetComponent<Renderer>();
        
        //changeColors(i);
    }

    /// <summary>
    /// setMaterialsにセットされたマテリアルに変更をする　
    /// </summary>
    /// <param name="i"></param>
    public void changeColors(byte i)
    {
        rend.material = setMaterials[i];
    }

    public Material GetColor(byte i)
    {
        return setMaterials[i];
    }
}
