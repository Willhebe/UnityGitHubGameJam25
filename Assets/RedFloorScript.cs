using UnityEngine;

public class RedFloorCript : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(myPrefab, new Vector3(0, 0.5f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
