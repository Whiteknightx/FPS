using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int spawnNumber;
    [SerializeField] private int spawnMinX,SpawnMaxX,spawnMinZ, SpawnMaxZ;
    private Vector3 _spawnPosition;
    private void Start() {

        for (int i = 0; i < spawnNumber; i++) {
            _spawnPosition = new Vector3(x: Random.Range(transform.position.x + spawnMinX, transform.position.x + SpawnMaxX), transform.position.y, z: Random.Range(transform.position.z + spawnMinZ, transform.position.z + SpawnMaxZ));
            Instantiate(enemyPrefab, _spawnPosition, Quaternion.identity);
        }
    }
}
