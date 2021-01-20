using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    [SerializeField]
    List<Material> setMaterials = new List<Material>();

    //Renderer rend;

    // Start is called before the first frame update
    void Awake()
    {

    }

    public void changeColors(byte i)
    {
        //rend.material = setMaterials[i];
    }

    /// <summary>
    /// setMaterialsにセットされたマテリアルを返す　
    /// </summary>
    /// <param name="i"></param>
    public Material GetColor(byte i)
    {
        return setMaterials[i];
    }
}
