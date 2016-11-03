using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class recycleLevel : MonoBehaviour {
    private Vector3 movePos;
    private List<sendToRecycler> recycleList;
    void sendThisHandler (sendToRecycler _r)
    {
        recycleList.Add(_r);
        print(recycleList.Count);
    }
	// Use this for initialization
	void Start () {
        recycleList = new List<sendToRecycler>();
        sendToRecycler.sendThis += sendThisHandler;
        
	}
	void OnTriggerEnter()
    {
        int i = UnityEngine.Random.Range(0, recycleList.Count - 1);
        movePos.x = Statics.nextPos;
        recycleList[i].transform.position = movePos;
        recycleList.RemoveAt(i);
        Statics.nextPos += Statics.distance;
    }
}
