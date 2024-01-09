using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSound : MonoBehaviour
{
    public PlayerControl player;
    private AudioSource BGMsound;
    // Start is called before the first frame update
    void Start()
    {
        BGMsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.gameover==true)
        {
            BGMsound.Stop();
        }
    }
}
