using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] List<Sprite> sprite = new List<Sprite>(9);
    [SerializeField] List<byte> buttonSelect = new List<byte>();

    byte num;
    bool isChange;

    byte nextWallNumber;

    GameObject s_WallGeneration;
    WallGeneration wallGeneration;

    // Start is called before the first frame update
    void Start()
    {
        isChange = false;
        for (byte i = 0; i < 3; i++)
        {
            buttonSelect.Add(10);
        }

        ChangeButtons();

        s_WallGeneration = GameObject.Find("WallManager");
        wallGeneration = s_WallGeneration.GetComponent<WallGeneration>();
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeButtons();
            isChange = true;
        }*/
    }

    public void ChangeButtons()
    {

        for (byte i = 0; i < 3; i++)
        {
            num = (byte)Random.Range(0, sprite.Count);
            for (byte j = i; j >= 0; j--)
            {
                if (buttonSelect[j] == num)
                {
                    i--;
                    break;
                }
                if (j == 0 && buttonSelect[0] != num)
                {
                    buttonSelect[i] = num;
                    break;
                }
            }
        }


        s_WallGeneration = GameObject.Find("WallManager");
        wallGeneration = s_WallGeneration.GetComponent<WallGeneration>();

        //次に生成する壁の色形をここで指定する。
        nextWallNumber = buttonSelect[Random.Range(0, 2)];
        //Debug.Log(nextWallNumber);

        GameObject.Find("NextWallText").GetComponent<ChangeText>().ChangeTextString = nextWallNumber.ToString();

        wallGeneration.NextWall = nextWallNumber;

        Debug.Log("ButtonManager.cs");
    }

    public byte GetSpriteNum(byte i)
    {
        return buttonSelect[i];
    }

    public Sprite GetSprite(byte i)
    {
        return sprite[buttonSelect[i]];
    }

    public bool IsChange
    {
        get { return isChange; }
        set { isChange = value; }
    }

    public byte NextWallNumber
    {
        get { return nextWallNumber; }
    }

}
