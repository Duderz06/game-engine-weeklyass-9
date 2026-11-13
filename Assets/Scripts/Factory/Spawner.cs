using UnityEngine;

public class EnemySpawner : MonoBehaviour
{



    public Factory F;
    public Transform SpawnPoint;

    public int Num = 0;

    public void Spawn(Transform Parent)
    {

        if (F == null || SpawnPoint == null)
        { 
            return; 
        }

        F.Spawn(Num, SpawnPoint.position);


    }



}
