using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    public static NpcSpawner instance;

    public GameObject npcPrefab1,npcPrefab2,npcPrefab3;
    public GameObject spawnedNpc;
    public bool isNpcSpawned;
    public int value;
    public int npcCounter;
    private GameObject mainNpcPrefab;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    void Update()
    {
        if(isNpcSpawned == false)
        {
            switch (npcCounter)
            {
                case 0:
                    mainNpcPrefab = npcPrefab1;
                    break;
                
                case 1:
                    mainNpcPrefab = npcPrefab2;
                    break;
                
                case 2:
                    mainNpcPrefab = npcPrefab3;
                    break;
            }

            spawnedNpc = Instantiate( mainNpcPrefab,transform.position,transform.rotation);
            isNpcSpawned = true;
        }

        if(spawnedNpc == null)
        {
            isNpcSpawned = false;
           value = UIManager.instance.soulValue ;
        }
    }
}
