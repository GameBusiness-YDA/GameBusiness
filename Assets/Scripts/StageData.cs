
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptable/Create StageData")]
public class StageData : ScriptableObject
{
    public int stageNum;
    public int walls;
    public float firstWallSpeed;
    public float secondWallSpeed;
    public float thirdWallSpeed;
}