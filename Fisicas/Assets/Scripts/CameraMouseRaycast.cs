using UnityEngine;

public class CameraMouseRaycast : MonoBehaviour
{

    public Camera camera;
    public Rigidbody objectSelected = null;

    void FixedUpdate()
    {

        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(camera.transform.position, hit.point, Color.blue);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //hit.collider.gameObject.SetActive(false);
                objectSelected = hit.rigidbody;
            }
        }
    }
}
