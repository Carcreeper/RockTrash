using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocar : MonoBehaviour
{
    public GameObject queso;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", 2);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(queso, new Vector3(0, 2, 0), Quaternion.identity);
    }
}
