using UnityEngine;
using UnityEngine.AI;
public class Ai : MonoBehaviour
{
    public enum GhostState
    {
        WANDER,
        CHASE,
        RETURNHOME,
    }

    public GhostState currentState = GhostState.Wander;
    public Transform player;
    public Transform home;
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case GhostState.Wander:
            Wander();
            break;

            case GhostState.Chase:
            Chase();
            break;

            case GhostState.ReturnHome:
            ReturnHome();
            break;
        }
       
       
       
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if(agent.remainingDistance <= 1.0f)
        {
             float x = Random.Range(-20.0f,20.0f);
             float z = Random.Range(-20.0f,20.0f);
             agent.destination = new Vector3(x,0.0f,z);
        }

        
    }

    void Wander()
    {
        
        if(agent.remainingDistance <= 1.0f)
        {
             float x = Random.Range(-20.0f,20.0f);
             float z = Random.Range(-20.0f,20.0f);
             agent.destination = new Vector3(x,0.0f,z);
        }
    }
}
