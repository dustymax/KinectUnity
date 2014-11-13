using UnityEngine;
using System.Collections;

public class LineToObject : MonoBehaviour {
    // Populate this array in the order you want the line to travel. 
    public Transform toTransform;
    public Material mat;

    private LineRenderer lineRenderer;

	void Start () {
	    lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.SetColors(Color.red, Color.red);
        lineRenderer.material = mat;
        lineRenderer.SetWidth(0.1f, 0.1f);
        lineRenderer.SetVertexCount(2);
	}

    void Update()
    {
        lineRenderer.SetPosition(0, gameObject.transform.position);
        lineRenderer.SetPosition(1, toTransform.position);
	}
}