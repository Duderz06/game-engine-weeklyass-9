using UnityEngine;

public class SpawnThingEveryFrame : MonoBehaviour
{

    public GameObject Obj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Instantiate(Obj,transform.position,transform.rotation);
        Instantiate(Obj,transform.position,transform.rotation);
        Instantiate(Obj,transform.position,transform.rotation);
        Instantiate(Obj,transform.position,transform.rotation);
        Instantiate(Obj,transform.position,transform.rotation);

    }
}
