using UnityEngine;
using UnityEngine.InputSystem;

public class InstantiatePrefabMonoBehaviourScript : MonoBehaviour
{
    // Reference to the prefab. Drag a prefab into this field in the Inspector.
    public GameObject myPrefab;
    public GameObject myPrefab2;
    public GameObject myPrefab3;

    // number to keep count of GameObjects in scene
    public static int count = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // This script will simply instantiate the prefab when the game starts.

    void Start()
    {
        // Instantiate a row of voles with zero rotation.
        InstantiateRowVoles();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputSystem.actions.FindAction("Attack").WasPressedThisFrame())
        {
            InstantiateRowVoles();
        }
    }

    void InstantiateRowVoles()
    {
        Instantiate(myPrefab, new Vector3(5 * count, 2, 0), Quaternion.identity);
        Instantiate(myPrefab2, new Vector3(5 * count, 2, 5), Quaternion.identity);
        Instantiate(myPrefab3, new Vector3(5 * count, 2, 10), Quaternion.identity);

        count++;
    }
}
