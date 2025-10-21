using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool floorContact;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            print("Toque");
        }
        if (collision.gameObject.tag == "Floor")
        {
            floorContact = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            floorContact = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            other.gameObject.SetActive(false);
            print("GOL!!");
        }
    }
}
