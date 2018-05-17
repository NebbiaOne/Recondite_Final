using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointSystem : MonoBehaviour {

	public List<Transform> wayPoints = new List<Transform> { };
	[SerializeField] int numberOfWayPoints;
	public int targetWayPoint = 0;
	[SerializeField] float speed = 400f;
	[SerializeField] float waitTime = 2f;
	[SerializeField] float distance;

	NavMeshAgent _agent;
	public bool playerFound = false;
	Coroutine movingEnemy;

	// Use this for initialization
	void Start () {
		_agent = GetComponent<NavMeshAgent> ();
		
		// float distance = Vector3.Distance (gameObject.transform.position, wayPoints[targetWayPoint].position);
		// float distance = _agent.remainingDistance;

		// if (distance > 0) {
		// Move ();
		// }

		movingEnemy = StartCoroutine (WaitForWaypoint (NextDestination (true)));
	}

	// Update is called once per frame
	void Update () {

	}

	public Vector3 NextDestination (bool overrideIndex = false) {
		numberOfWayPoints = wayPoints.Count - 1; //3

		if (overrideIndex == false) {

			if (targetWayPoint >= numberOfWayPoints) { //if (3 >= 3)
				targetWayPoint = 0;
			} else {
				targetWayPoint++; //0++
			}
		} else {
			targetWayPoint = 0;
		}

		Debug.Log ("Next Destination: " + targetWayPoint);
		return wayPoints[targetWayPoint].position;

		// gameObject.transform.LookAt (wayPoints[targetWayPoint].transform.position);
		// gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
	}

	IEnumerator WaitForWaypoint (Vector3 _dest) {
		_agent.destination = _dest;
		Debug.Log ("Agent moving to destination " + targetWayPoint);
		while (!_agent.hasPath){
			yield return null;
		}
		while (_agent.realRemainingDistance () > _agent.stoppingDistance && playerFound == false) {
			// Debug.Log ("Remaining Distance: " + _agent.realRemainingDistance ());
			if (_agent.isStopped) {
				Debug.Log ("Agent stopped");
			}
			yield return null;
		}
		// Debug.Log ("Agent Next Phase");
		if (_agent.realRemainingDistance () <= _agent.stoppingDistance + 0.5f) {
			Debug.Log ("Agent reached destination");
			float waitTimeMod = waitTime;
			while (waitTimeMod > 0 && playerFound == false) {
				waitTimeMod -= Time.deltaTime;
				yield return null;
			}
			if (playerFound == false) {
				movingEnemy = StartCoroutine (WaitForWaypoint (NextDestination ()));
			}
		} else {
			Debug.Log ("Agent move interrupted");
		}
	}
}