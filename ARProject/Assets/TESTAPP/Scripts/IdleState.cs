using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IdleState : AIState
{
    public float idleMin;
    public float idleMax;

    private float idleTime;

    

    public override void OnEnterState()
    {
        idleTime = Random.Range(idleMin, idleMax);

        StartCoroutine(Idle());

        
    }


    public override void OnExitState()
    {
        StopAllCoroutines();
    }


    private IEnumerator Idle() {

        yield return new WaitForSeconds(idleTime);
     
        controller.ChangeState(controller.patrolState);

    }

}