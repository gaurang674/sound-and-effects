using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public PlayerControl playerControl;
    Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControl.gameover == false)
        {
            transform.Translate(Vector3.right * 10f * Time.deltaTime);
            if(transform.position.z < startpos.z-56.5f)
            {
                transform.position = startpos;
            }
        }
    }
}
