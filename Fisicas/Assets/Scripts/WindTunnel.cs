using UnityEngine;

public class WindTunnel : MonoBehaviour
{
    public float force = 10;
    Rigidbody objectIn = null;
    //private void OnTriggerStay(Collider other)
    //{
    //    other.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
    //}

    private void OnTriggerEnter(Collider other)
    {
        objectIn = other.GetComponent<Rigidbody>();
        objectIn.linearVelocity = Vector3.zero;
    }

    private void OnTriggerExit(Collider other)
    {
        objectIn = null;
        gameObject.SetActive(false);
    }

    public void FixedUpdate()
    {
        if (objectIn != null)
        {
            objectIn.AddForce(Vector3.up * force);
        }
    }
}
