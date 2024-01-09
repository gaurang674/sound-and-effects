using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public ParticleSystem explosionParticle;
    public ParticleSystem DirtParticle;
    public AudioClip CrashSound;
    public AudioClip JumpSound;
    private AudioSource playerAudio;
    public float gravityModifier;
    private Animator playerAnim;
    private bool isOnGround=true;
    public bool gameover=false;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
        rb=GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isOnGround && !gameover)
        {
            rb.AddForce(Vector3.up * 10,ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            DirtParticle.Stop();
            playerAudio.PlayOneShot(JumpSound,1.0f);
        }
    }
    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("ground"))
        {
            isOnGround = true;
            DirtParticle.Play();
        }

        if(col.gameObject.CompareTag("obstacle"))
        {
            gameover = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            DirtParticle.Stop();
            playerAudio.PlayOneShot(CrashSound,1.0f);
        }
    }
}
