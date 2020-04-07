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
            Debug.Log(_camera.transform.forward);
            if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, 3))
            {
                if (hit.collider.CompareTag("Cube"))
                {
                    Debug.DrawRay(_camera.transform.position, _camera.transform.forward * hit.distance, Color.blue, 200);
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.collider.CompareTag("Ball"))
                {
                    hit.collider.attachedRigidbody.AddExplosionForce(200f, hit.point, 2f);
                }
            } 
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, 3))
            {
                Vector3 newPosition = hit.point + new Vector3(1f, 1f, 1f);
                PlaceBlock(newPosition);
            }
        }
    }
}
