using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    float PositionY;

    public GameObject[] SpawnObject;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawningCubes", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawningCubes()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        var obj = Instantiate(SpawnObject[Random.Range(0, 3)], transform.position, transform.rotation);
        Destroy(obj, 7.0f);
    }
}