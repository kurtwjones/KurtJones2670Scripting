using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleLevel : MonoBehaviour {
    public List<Recycler> recyclableList;
    private int i = 0;
    

    void start()
    {
        recyclableList = new List<Recycler>();
        Recycler.RecycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(Recycler _R)
    {
        recyclableList.Add(_R);
    }

    void onTriggerEnter()
    {
        i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
        newLocation.x = staticVars.nextSectionPos;
        recyclableList[i].cube.position = newLocation;
        staticVars.nextSectionPos += staticVars.distance;
        recyclableList.RemoveAt(i);
        if (recyclableList.Count > 0)
            recyclableList.RemoveAt(i);     
    }
}
