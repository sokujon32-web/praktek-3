using UnityEngine;
using UnityEngine.AI;

public class scripted : MonoBehaviour
{
    [SerializeField] private Transform target;
    NavMeshAgent agent;

    void Start()
    {
      agent = GetComponent<NavMeshAgent>();  
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}
