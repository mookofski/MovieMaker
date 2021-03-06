using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Inst_SE : MonoBehaviour
{
    //あるく効果音
    public AudioClip sound_Walk;
    //はねる効果音
    public AudioClip sound_Jump;
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        //こんぽーねんとを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            //あるく効果音 ならす
            audioSource.PlayOneShot(sound_Walk);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //はねる効果音 ならす
            audioSource.PlayOneShot(sound_Jump);
        }
    }
}
