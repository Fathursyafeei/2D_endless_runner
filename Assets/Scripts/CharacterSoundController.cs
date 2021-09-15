using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{

    public AudioClip jump;
    private AudioSource audioPlayer;


    // Start is called before the first frame update
    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
