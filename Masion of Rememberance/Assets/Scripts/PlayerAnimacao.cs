using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimacao : MonoBehaviour
{
    private Player1 player;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player1>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Horizontal", player.direction.x);
        anim.SetFloat("Vertical", player.direction.y);
        anim.SetFloat("Speed", player.direction.magnitude);

    }
}
