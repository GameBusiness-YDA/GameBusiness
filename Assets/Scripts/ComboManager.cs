using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboManager : MonoBehaviour
{
    public static ComboManager Instance;

    [SerializeField]int MaxCombo;
    [SerializeField]int NowCombo;
    [SerializeField] int ComboCount;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        MaxCombo = 0;
        NowCombo = 0;
        ComboCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComboPuls()
    {
        NowCombo++;
        ComboCount++;
        if (MaxCombo < NowCombo) MaxCombo = NowCombo;
    }

    public void ComboReset()
    {
        NowCombo = 0;
        ComboCount++;
    }

    public int GetCombo()
    {
        return NowCombo;
    }

}
