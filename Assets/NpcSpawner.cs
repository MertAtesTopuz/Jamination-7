using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    public GameObject npcPrefab;
    public GameObject spawnedNpc;
    public bool isNpcSpawned;
    public int value;
    
    void Update()
    {
        if(isNpcSpawned == false)
        {
            spawnedNpc = Instantiate(npcPrefab,transform.position,transform.rotation);
            isNpcSpawned = true;
        }

        if(spawnedNpc == null)
        {
            isNpcSpawned = false;
           value = UIManager.instance.soulValue ;
        }
    }
}
