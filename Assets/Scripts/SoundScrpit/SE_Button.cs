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
   
    public void onClick()
    {
        audioSource.PlayOneShot(ButtonSE);
    }
}
