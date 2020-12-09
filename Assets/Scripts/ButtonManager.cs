using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    List<ButtonObject> buttonNum = new List<ButtonObject>();
    [SerializeField]List<Sprite> sprite = new List<Sprite>();
    [SerializeField,Range(0,2)]List<byte> buttonSelect = new List<byte>();

    byte num;
    bool isChange;

    // Start is called before the first frame update
    void Start()
    {
        isChange = false;
        for(byte i = 0; i < 3; i++)
        {
            buttonSelect.Add(10);
        }
        
        ChangeButtons();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeButtons();
            isChange = true;
        }
    }

    public void ChangeButtons()
    {
        for(byte i = 0; i < 3; i++)
        {
            num = (byte)Random.Range(0, sprite.Count);
            for(byte j = i; j >= 0; j--)
            {
                if(buttonSelect[j] == num)
                {
                    i--;
                    break;
                }
                if(j == 0 && buttonSelect[0] != num)
                {
                    buttonSelect[i] = num;
                    break;
                }
            }
        }
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
}
