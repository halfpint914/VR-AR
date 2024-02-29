using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator : MonoBehaviour
{
    private Animator anim;
    private AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        aud = this.GetComponent<AudioSource>();
        NextAnim();
    }

    void NextAnim() {
        anim.SetTrigger("NextAnim");
        aud.Play();
    }
}
