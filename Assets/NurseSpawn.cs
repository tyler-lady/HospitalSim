using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseSpawn : MonoBehaviour
{
    public GameObject nursePrefab;
    public int numNurses;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numNurses; i++)
        {
            Instantiate(nursePrefab, this.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
