using System.Collections;
using UnityEngine;

public class DeleteAfterTime : MonoBehaviour
{

    public float Time = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DestroyAfter());
    }


    public IEnumerator DestroyAfter() {


        yield return new WaitForSeconds(Time);

        Destroy(gameObject);
    
    
    }

}
