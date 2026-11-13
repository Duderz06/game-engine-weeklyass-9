using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public List<GameObject> Prefabs = new List<GameObject>();

    public GameObject Spawn(GameObject Prefab, Vector3 Position, Quaternion Rotation)
    {

        if (Prefab == null)
        {
            return null;

        }

        GameObject thing = Instantiate(Prefab, Position, Rotation);

      
        return thing;

    }



    public GameObject Spawn(GameObject Prefab, Vector3 Position) {

        return Spawn(Prefab, Position, Quaternion.identity);
    }

    public GameObject Spawn(int Index, Vector3 Position)
    {

        if (Index < 0 || Index >= Prefabs.Count)
        {
            return null;
        }


        return Spawn(Prefabs[Index], Position);
    }



}
