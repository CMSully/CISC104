using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class RedBallCollisionManager : BallCollisionManager
{
    public Text Blammo;
    float timer = 0;
    bool starttime = false;
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");
        // Displays the text "BLAMMO!" on the side for 5 seconds when
        //the red ball collides with another ball (except the black one)
        Blammo.text = "BLAMMO!";
        starttime = true;

        if (OtherBall.GetComponent<BlackBallCollisionManager>() != null)
        {
            Debug.Log("Red Collided With Black");

            Blammo.text = "";
        }

    }
    public void Update()
    {
        if(starttime)
        {
            timer += Time.deltaTime;
        }
        if(timer > 5.0)
        {
            starttime = false;
            timer = 0;
            Blammo.text = "";
        }
    }
}

