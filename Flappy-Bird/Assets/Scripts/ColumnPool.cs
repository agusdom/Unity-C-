using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColumnPool : MonoBehaviour
{
    public int columnPoolSize = 5;
    public GameObject columnPrefabs;

    public float columnMin = -2.9f;
    public float columnMax =  1.4f;
    private float spawnXPosition = 10f;

    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-14,0);

    private float TimeSizeLastSpawn;
    public  float SpawnRate;

    private int currentColumn;

    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for(int a=0; a<columnPoolSize; a++)
        {
            columns[a] = Instantiate(columnPrefabs, objectPoolPosition, Quaternion.identity);
        }
        SpawColumn();
    }

    // Update is called once per frame
    void Update()
    {
        TimeSizeLastSpawn += Time.deltaTime;
        if(TimeSizeLastSpawn >= SpawnRate && !GameController.instance.gameOver)
        {
            TimeSizeLastSpawn = 0;
            SpawColumn();
            
        }
    }

    void SpawColumn()
    {
        float spawnYPosition = Random.Range(columnMin, columnMax);
        columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

        currentColumn++;
        if (currentColumn >= columnPoolSize)
        {
            currentColumn = 0;
        }
    }
}
