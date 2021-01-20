using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    public string GetTag(byte i)
    {
        string taged="";

        switch (i)
        {
            case 0:
                taged = "Tryangle_Red";
                break;
            case 1:
                taged = "Tryangle_Blue";
                break;
            case 2:
                taged = "Tryangle_Yellow";
                break;
            case 3:
                taged = "Square_Red";
                break;
            case 4:
                taged = "Square_Blue";
                break;
            case 5:
                taged = "Square_Yellow";
                break;
            case 6:
                taged = "Circle_Red";
                break;
            case 7:
                taged = "Circle_Blue";
                break;
            case 8:
                taged = "Circle_Yellow";
                break;
        }


        return taged;
    }
}
