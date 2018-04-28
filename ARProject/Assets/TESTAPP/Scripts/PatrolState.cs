
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : AIState
{
    private Vector3 targetPosition;

    public override void OnEnterState()
    {
        targetPosition = DummyRandomPosition();

        controller.navMeshMotor.GoToDestination(targetPosition);
        StartCoroutine(Patrol());
    }

    public override void OnExitState()
    {
        StopAllCoroutines();
    }


    public Vector3 DummyRandomPosition() {

        return new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));

    }

    public IEnumerator Patrol() {

        while (Vector3.Distance(transform.position, targetPosition) < 0.5f) {


            yield return null;

        }

        controller.ChangeState(controller.idleState);
    }
}
