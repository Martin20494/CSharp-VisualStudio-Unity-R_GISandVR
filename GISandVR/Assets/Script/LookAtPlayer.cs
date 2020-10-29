using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject playerGameObj;
    // Start is called before the first frame update
    void Start()
    {
        playerGameObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerGameObj != null)
        {
            transform.LookAt(playerGameObj.transform);

        }
        else
        {
            Debug.Log("Player not found");
        }
    }
}
