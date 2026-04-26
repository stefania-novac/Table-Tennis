using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public float speed = 3f;
    public Transform spawnPoint;

    void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        transform.position = spawnPoint.position;
    }

    // public void ResetBall()
    // {
    //     transform.position = spawnPoint.position;

    //     Rigidbody rb = GetComponent<Rigidbody>();
    //     rb.linearVelocity = Vector3.zero;

    //     StartCoroutine(ServeAfterDelay(1f));
    // }

    // IEnumerator ServeAfterDelay(float delay)
    // {
    //     yield return new WaitForSeconds(delay);

    //     Rigidbody rb = GetComponent<Rigidbody>();

    //     float dir = Random.value > 0.5f ? 1 : -1;

    //     Vector3 direction = new Vector3(dir, 0, Random.Range(-0.5f, 0.5f)).normalized;

    //     rb.linearVelocity = direction * speed;
    // }
}