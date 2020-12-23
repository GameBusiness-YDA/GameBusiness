using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Button : MonoBehaviour
{
    public AudioClip ButtonSE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            onClick();
        } 
    }

    public void onClick()
    {
        audioSource.PlayOneShot(ButtonSE);
    }
}
