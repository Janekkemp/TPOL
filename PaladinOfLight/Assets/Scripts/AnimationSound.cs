using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSound : MonoBehaviour
{

    public AudioSource animationSoundPlayerFootstep;
    public AudioSource animationSoundPlayerJump;
    // Start is called before the first frame update
    void Start()
    {
        animationSoundPlayerFootstep = GetComponent<AudioSource>();
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Footstep()
    {
        FindObjectOfType<AudioManager>().Play("Footstep");
        print("footstep");
    }

    private void Jump()
    {
        FindObjectOfType<AudioManager>().Play("Jump");

    }

    
}
