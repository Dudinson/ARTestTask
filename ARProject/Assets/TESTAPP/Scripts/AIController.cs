using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {


    public NavMeshMotor navMeshMotor;

    public AIState currentState;

    public AIState idleState;
    public AIState patrolState;

    void Start() {

        navMeshMotor = GetComponent<NavMeshMotor>();
        idleState = GetComponent<IdleState>();

        currentState = idleState;
        currentState.OnEnterState();
    }



    public void ChangeState(AIState state) {

        currentState.OnExitState();

        currentState = state;
        currentState.OnEnterState();

    }


}

