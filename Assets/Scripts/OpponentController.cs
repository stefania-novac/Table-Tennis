using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform ball;
    public float speed = 15f;

    void Update()
    {
        Vector3 target = new Vector3(transform.position.x, transform.position.y, ball.position.z);

        transform.position = Vector3.Lerp(
            transform.position,
            target,
            speed * Time.deltaTime
        );
    }
}
