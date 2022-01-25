using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCWonderScript : MonoBehaviour
{
    [SerializeField] Transform pos1, pos2;
    [Tooltip("The distance the NPC needs to be from its target location before finding a new location")]
    [SerializeField] float newLocationdis;

    [Space(10)]
    [SerializeField] int minWaitTimer = 1;
    [SerializeField] int maxWaitTimer = 10;

    [SerializeField] float rotationSpeed = 3f;

    NavMeshAgent agent;
    Animator anim;
    Vector3 location;

    float waitTimer = 0f;

    int walkHash = Animator.StringToHash("IsWalking");

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        FindNewPath();
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance <= newLocationdis)
        {
            waitTimer -= 1 * Time.deltaTime;
            anim.SetBool(walkHash, false);
            if (waitTimer <= Mathf.Epsilon)
            {
                FindNewPath();
                waitTimer = newWaitTime();
            }
        }
        else
        {
            anim.SetBool(walkHash, true);
        }
    }

    private void FixedUpdate()
    {
        Vector3 direction = (location + new Vector3(0.1f,0f,0.1f))- transform.position;
        Quaternion toRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    }

    void FindNewPath()
    {
        float randomX = Random.Range(pos1.position.x, pos2.position.x);
        float randomY = Random.Range(pos1.position.y, pos2.position.y);
        float randomZ = Random.Range(pos1.position.z, pos2.position.z);

        location = new Vector3(randomX, randomY, randomZ);
        agent.SetDestination(location);
    }

    int newWaitTime()
    {
        int RandomWait = Random.Range(minWaitTimer, maxWaitTimer);
        return RandomWait;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(location, 0.5f);
    }
}
