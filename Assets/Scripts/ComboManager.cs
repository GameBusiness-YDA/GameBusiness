using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboManager : MonoBehaviour
{
    public static ComboManager Instance;

    [SerializeField] int maxCombo;
    [SerializeField] int nowCombo;
    [SerializeField] int comboCount;
    [SerializeField] int comboMissed;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        maxCombo = 0;
        nowCombo = 0;
        comboCount = 0;
        comboMissed = 0;
    }

    private void Update()
    {
        if (comboCount >= 10)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().IsGameClear = 3;
        }
    }


    public void ComboPuls()
    {
        nowCombo++;
        comboCount++;
        if (MaxCombo <= NowCombo) MaxCombo = NowCombo;
        //GameObject.Find("ComboText").GetComponent<ChangeText>().ChangeTextString = NowCombo.ToString() + "Combo";
    }

    public void ComboReset()
    {
        nowCombo = 0;
        comboMissed++;
        //GameObject.Find("ComboText").GetComponent<ChangeText>().ChangeTextString = NowCombo.ToString() + "Combo";
    }


    #region GetSet
    public int MaxCombo
    {
        get { return maxCombo; }
        set { maxCombo = value; }
    }

    public int NowCombo
    {
        get { return nowCombo; }
        set { nowCombo = value; }
    }

    public int ComboMissCount
    {
        get { return comboMissed; }
    }
    #endregion
}
