using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public int isPlayerSide;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (isPlayerSide == 1)
                Debug.Log("Lost Point");
            else if (isPlayerSide == 2)
                Debug.Log("Won Point");

            other.GetComponent<BallController>().ResetBall();
        }
    }
}