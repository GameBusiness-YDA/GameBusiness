using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitleManager : MonoBehaviour
{
    public Image titleStart;
    public float alpha_Sin;
    float speed = 0.5f;
    float red, green, blue;
    

    // Start is called before the first frame update
    void Start()
    {
        red = titleStart.GetComponent<Image>().color.r;
        green = titleStart.GetComponent<Image>().color.g;
        blue = titleStart.GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        titleStart.GetComponent<Image>().color = new Color(red, green, blue, alpha_Sin);
        alpha_Sin = Mathf.Sin(Time.time) / 2 + 0.5f;

        if (Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene("StageSelect");
        }
    }
}
