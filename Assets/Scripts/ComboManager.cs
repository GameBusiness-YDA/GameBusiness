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


    GameObject s_gameTimerText;
    ChangeText changeText;

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


        s_gameTimerText = GameObject.Find("ComboText");
        changeText = s_gameTimerText.GetComponent<ChangeText>();
    }

    private void Update()
    {
        changeText.ChangeTextString = NowCombo + "Combo!";
    }

    public void ComboPuls()
    {
        nowCombo++;
        comboCount++;
        if (MaxCombo <= NowCombo) MaxCombo = NowCombo;
    }

    public void ComboReset()
    {
        nowCombo = 0;
        comboMissed++;
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

    public int ComboCount
    {
        get { return comboCount; }
    }

    public int ComboMissCount
    {
        get { return comboMissed; }
    }
    #endregion
}
