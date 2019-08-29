using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [Header("Player")]
    public GameObject playerStart;

    public GameObject playerFinish;
    public GameObject player;

    [Header("NPCs")]
    public List<GameObject> npcSpawnpoints;
    public List<GameObject> npcGameObjects;
    private List<GameObject> previousSpawnPoints;

    [Header("Objects")]
    public List<GameObject> objectSpawnpoints;
    public List<GameObject> objectGameObjects;



    private float spawnOffset = 0.8f;

    private void Start()
    {
        player.transform.position = new Vector3(playerStart.transform.position.x, playerStart.transform.position.y + spawnOffset);
        SpawnNPCs();
        SpawnObjects();
    }

    private void SpawnNPCs()
    {
        if (npcGameObjects.Count > 0)
        {
            foreach (GameObject spawnPoint in npcSpawnpoints)
            {
                var randomObjectIndex = Random.Range(0, npcGameObjects.Count);
                var spawnObject = npcGameObjects[randomObjectIndex];

                Vector3 position = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y + spawnOffset);
                Instantiate(spawnObject, position, Quaternion.identity);

            }
        }
        else
        {
            Debug.Log("[SpawnNPCs] -- No NPCs to spawn");
        }

    }

    private void SpawnObjects()
    {
        if (objectGameObjects.Count > 0)
        {
            foreach (GameObject spawnPoint in objectSpawnpoints)
            {
                var randomObjectIndex = Random.Range(0, objectGameObjects.Count);
                var spawnObject = objectGameObjects[randomObjectIndex];

                Vector3 position = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y + spawnOffset);
                Instantiate(spawnObject, position, Quaternion.identity);

            }
        }
        else
        {
            Debug.Log("[SpawnObjects] -- No objects to spawn");
        }

    }
}