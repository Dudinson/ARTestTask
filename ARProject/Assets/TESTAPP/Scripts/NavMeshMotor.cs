using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMotor : MonoBehaviour {

    public NavMeshAgent navMeshAgent;

    void Start() {

        navMeshAgent = GetComponent<NavMeshAgent>();

    }


    public void GoToDestination(Vector3 targetPosition) {

        if (gameObject.activeSelf)
        {
            navMeshAgent.destination = targetPosition;
        }

    }


}
