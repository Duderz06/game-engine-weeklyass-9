using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public GameObject Obj;

    public int AmountToSpawn = 10;
    public int AmountToSpawnPerFrame = 5;
    private List<GameObject> Things = new List<GameObject>();

    public int WhichObj = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnAtStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnAtStart() { 
    
    
        yield return null;



        while (Things.Count < AmountToSpawn)
        {
            GameObject a = Instantiate(Obj, transform.position, transform.rotation);

            Things.Add(a);
            a.SetActive(false);

        }

        StartCoroutine(SpawningStuff());

    }


    public IEnumerator SpawningStuff()
    {

        while (true) {



            for (int i = 0; i < AmountToSpawnPerFrame; i++) {

                Things[WhichObj].SetActive(true);
                Things[WhichObj].transform.position = transform.position;
                Things[WhichObj].transform.rotation = transform.rotation;

                WhichObj++;
                if (WhichObj >= AmountToSpawn) { 
                
                    WhichObj = 0;
                
                }
            
            }


            yield return null;
        }



    }


}
