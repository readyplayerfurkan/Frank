using System;
using Management.ObjectPool;
using TMPro;
using UnityEngine;

public class ExampleScript : ObjectPooling<GameObject>
{
    private void Start()
    {
        ObjectPool();
        for (int i = 0; i < 5; i++)
        {
           itemInstantiate = GetItem();
           if(i == 3)
               itemInstantiate.transform.position = transform.position + new Vector3(0, 2f, 0);
        }
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            ReleaseAll();
    }
}
