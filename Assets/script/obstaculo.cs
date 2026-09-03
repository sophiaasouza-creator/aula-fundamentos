using UnityEngine;

public class obstaculo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float tamanhometeoro = Random.Range(0.5f, 2f);
        transform.localScale = new Vector3(tamanhometeoro, tamanhometeoro, 1);
    }

    void Update()
    {
        
    }
}
