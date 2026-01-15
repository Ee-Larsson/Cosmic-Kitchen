using UnityEngine;

public class audio_manager : MonoBehaviour
{
    [Header("----------Audio Sources----------")]
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource sfx;

    [Header("----------Sounds----------")]
    public AudioClip background;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        music.clip = background;
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
