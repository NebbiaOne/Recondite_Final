using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public static class ExtensionMethods {

	public static float realRemainingDistance (this NavMeshAgent agent) {
		float distance = 0.0f;
		Vector3[] corners = agent.path.corners;
		for (int c = 0; c < corners.Length - 1; ++c) {
			distance += Mathf.Abs ((corners[c] - corners[c + 1]).magnitude);
		}
		return distance;
	}
}