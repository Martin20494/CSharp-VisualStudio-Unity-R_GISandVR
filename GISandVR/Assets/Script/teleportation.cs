using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
    [SerializeField]
    private GameObject targetObject;

    private GameObject currentTargetObject;

    // Update is called once per frame
    void Update()
    {
        if (targetObject != null)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Ended)
                {
                    if(currentTargetObject != null)
                    {
                        currentTargetObject.SetActive(true);
                    }
                    Teleport(targetObject.transform.position);
                    currentTargetObject = targetObject;
                    currentTargetObject.SetActive(false);
                }
            }  
        }
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.CompareTag("marker"))
            {
                targetObject = hit.collider.gameObject;
                
                //Teleport(hit.collider.transform.position);
            }
            else
            {
                targetObject = null;
            }
        }
        else
        {
            targetObject = null;
        }
    }

    private void Teleport(Vector3 position)
    {
        transform.parent.position = position; 
    }
}
