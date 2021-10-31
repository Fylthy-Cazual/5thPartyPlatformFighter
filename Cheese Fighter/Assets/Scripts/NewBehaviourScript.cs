using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : Rat
{


    public override void Update()
    {
        base.Update();
        if (!action)
        {
            if (Input.GetKeyDown(KeyCode.T)) //Teleport
            {
                teleport(0, 0);
            }

        }
    }
    public override void special()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("poop");
            //StartCoroutine(specialU());
        }
        else
        {
            Debug.Log("not poop");
            base.special();
        }
    }

    void teleport(float x, float y)
    {
        transform.position = new Vector3(x, y, transform.position.z);
    }


    //IEnumerator specialU()
    //{
    //    action = true;
    //    //animator.SetTrigger("Jab-Air");
    //    //for (int i = 0; i < 24; i++)
    //    //{
    //    //    rb.velocity = new Vector3(0f, 0f, 0f);
    //    //    yield return Utils.Frames(1);
    //    //}
    //    teleport(transform.position.x, transform.position.y+5);
    //    action = false;
    //    //animator.SetTrigger("Return");
    //}
}
