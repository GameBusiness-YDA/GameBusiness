using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboManager : MonoBehaviour
{
    
    [SerializeField]int MaxCombo;
    [SerializeField]int NowCombo;
    [SerializeField] int ComboCount;

    // Start is called before the first frame update
    void Start()
    {
        MaxCombo = 0;
        NowCombo = 0;
        ComboCount = 0;
    }

    public void ComboPuls()
    {
        NowCombo++;
        ComboCount++;
        if (MaxCombo <= NowCombo) MaxCombo = NowCombo;
        //GameObject.Find("ComboText").GetComponent<ChangeText>().ChangeTextString = NowCombo.ToString() + "Combo";
    }

    public void ComboReset()
    {
        NowCombo = 0;
        ComboCount++;
        //GameObject.Find("ComboText").GetComponent<ChangeText>().ChangeTextString = NowCombo.ToString() + "Combo";
    }

    public int GetCombo()
    {
        return NowCombo;
    }

}
