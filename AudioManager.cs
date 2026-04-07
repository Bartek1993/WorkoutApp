using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource mainMusic;
    public float musicVolume, sfxVolume;
    public AudioSource mainSfx;
    public AudioClip[] sfx;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainMusic.volume = musicVolume;
        mainSfx.volume = sfxVolume;
    }


    public void OnCancel()
    {
        mainSfx.PlayOneShot(sfx[0]);
    }
    public void OnApprove()
    {
        mainSfx.PlayOneShot(sfx[1]);
    }
}
