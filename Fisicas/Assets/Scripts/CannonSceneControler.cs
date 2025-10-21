using UnityEngine;

public class CannonSceneControler : MonoBehaviour
{
    [Range(30, 80)]
    public float cannonAngle;
    [Range(100, 1000)]
    public float cannonForce;
    public Transform cannon;
    public Transform cannonSpawnPoint;
    public Rigidbody cubeProyectile;
    public Rigidbody sphereProyectile;
    public CameraMouseRaycast cameraMouseRaycast;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cannon.rotation = Quaternion.Euler(cannonAngle, 0, 0);
        if (cameraMouseRaycast.objectSelected != null)
        {
            cameraMouseRaycast.objectSelected.transform.position = cannonSpawnPoint.position;
            cameraMouseRaycast.objectSelected.AddForce(cannon.up * cannonForce);

            cameraMouseRaycast.objectSelected = null;
        }
    }
}
