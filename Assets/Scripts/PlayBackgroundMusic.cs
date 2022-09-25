using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBackgroundMusic : MonoBehaviour
{
    public AudioClip introMusic;
    private AudioSource audioSource;
    public AudioClip normalBackgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        StartCoroutine(PlayIntroMusic());
    }

    IEnumerator PlayIntroMusic()
    {
        audioSource.clip = introMusic;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        audioSource.clip = normalBackgroundMusic;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
