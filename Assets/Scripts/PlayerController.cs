using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform aimTarget;
    public LayerMask planeLayer;
    float force = 5f;

    bool hitting;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Input.GetMouseButtonDown(1))
        {
            hitting = true;
        }
        else if(Input.GetMouseButtonUp(1))
        {
            hitting = false; 
        } 

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (hitting)
        {
            aimTarget.Translate(new Vector3(v, 0, -h) * 2 * Time.deltaTime);
        }

        if (Physics.Raycast(ray, out hit, 100f, planeLayer) && !hitting)
        {
            Vector3 target = hit.point;

            target.y = transform.position.y;

            transform.position = target;
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Ball"))
        {
            Vector3 dir = aimTarget.position - transform.position;
            other.GetComponent<Rigidbody>().linearVelocity = dir.normalized * force + new Vector3(0, 3f, 0);
        }
    }
}
