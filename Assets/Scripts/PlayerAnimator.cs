using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    // References
    private Animator am;
    private PlayerMovement pm;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    private void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (pm.moveDir.x != 0 || pm.moveDir.y != 0)
        {
            am.SetBool("Move", true);

            SpriteDirectionChecker();
        }
        else
        {
            am.SetBool("Move", false);
        }
    }

    private void SpriteDirectionChecker()
    {
        if (pm.moveDir.x != 0)
        {
            sr.flipX = pm.moveDir.x < 0;
        }
        //if (pm.lastHorizontalVector < 0)
        //{
        //    sr.flipX = true;
        //}
        //else
        //{
        //    sr.flipX = false;
        //}
    }
}