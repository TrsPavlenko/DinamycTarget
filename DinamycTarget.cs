using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinamycTarget : MonoBehaviour
{
  public Transform Target; //Transform the current nearest target
   
  void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

   //Call this method when you need to update the nearest target
   void UpdateTarget()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("target"); //An array of all objects with the tag "target"
        float minDistance = Mathf.Infinity; //Distance to the nearest object
        GameObject nearestTarget = null; 

        foreach (GameObject target in targets)
        {
            float distanceToTarget = Vector3.Distance(transform.position, target.transform.position);
            
            ]if (distanceToTarget < minDistance) {
                minDistance = distanceToTarget;
                nearestTarget = target;
            }
        }

        if (nearestTarget != null)
        {
            Target = nearestTarget.transform;
            Debug.Log(nearestTarget.transform);
        }
        else
        {
            Target = null;
        }
    }
}
