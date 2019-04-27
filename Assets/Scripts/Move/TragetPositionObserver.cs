using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;


public class TragetPositionObserver : MonoBehaviour
{
    [SerializeField] private Vector3Value targetPosition;
    [SerializeField] private float setTargetPointDelayInSecond = 1f;
    NavMeshAgent agent;
    

    private float setTargetPointDelay;

    private void OnEnable()
    {
       ResetDelay();
       agent = GetComponent<NavMeshAgent>();
    }

    public void OnUpdate()
    {
        setTargetPointDelayInSecond -=Time.deltaTime;

        if (setTargetPointDelayInSecond<=0)
        {
            ResetDelay();
            agent.SetDestination(targetPosition.Value);
        }
    }

    private void ResetDelay()
    {
        setTargetPointDelay = setTargetPointDelayInSecond;
    }
}
