using UnityEngine;

public class BlockActions : MonoBehaviour
{
    public Camera _camera;
    public GameObject cube;
    public void PlaceBlock(Vector3 position)
    {
        Instantiate(cube, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, 3))
            {
                if (hit.collider.CompareTag("Cube"))
                {
                    Debug.DrawRay(_camera.transform.position, _camera.transform.forward * hit.distance, Color.blue, 200);
                    Destroy(hit.collider.gameObject);
                }
            } 
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, 3))
            {
                PlaceBlock(hit.point + 0.5f * Vector3.up);
            }
        }
    }
}
