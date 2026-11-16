using UnityEngine;

public class Spawner : MonoBehaviour
{



    public Factory F;
    public Transform SpawnPoint;

    public int Num = 0;

    public GameObject Spawn()
    {

        if (F == null || SpawnPoint == null)
        { 
            return null; 
        }

        GameObject ObjMade = F.Spawn(Num, SpawnPoint.position);

        return ObjMade;

    }



}
