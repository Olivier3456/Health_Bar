using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float distanceMin = 2f;

    [SerializeField] private bool lookAtTarget;



    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > distanceMin)
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (lookAtTarget) transform.LookAt(target.position);
        else transform.rotation = Quaternion.identity;
    }
}
