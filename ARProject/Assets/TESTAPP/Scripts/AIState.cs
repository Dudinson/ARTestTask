using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIState : MonoBehaviour {

    public AIController controller;

    void Start()
    {

        controller = GetComponent<AIController>();

    }


    abstract public void OnEnterState();
    abstract public void OnExitState();





}
