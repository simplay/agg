using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cube;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PlaceBlock(Transform transform)
    {
        Instantiate(cube, transform.position, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
