using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        //Shrinks the green ball by 50% when it collides with another ball
        transform.localScale = new Vector3(0.5F, 0.5F, 0.5F);

    }
}

