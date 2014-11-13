using UnityEngine;
using System.Collections;

public class CameraMatrix : MonoBehaviour {

	public float m00 = 1.05381003e+03f;
	public float m01 = 0f;
	public float m02 = 9.66121180e+02f;
	public float m03 = 0f;
	public float m10 = 0f;
	public float m11 = 1.05452404e+03f;
	public float m12 = 5.25726812e+02f;
	public float m13 = 0f;
	public float m20 = 0f;
	public float m21 = 0f;
	public float m22 = 1f;
	public float m23 = 0f;
	public float m30 = 0f;
	public float m31 = 0f;
	public float m32 = 0f;
	public float m33 = 1f;

	private Camera _camera;

	void Start () {
		_camera = GetComponent<Camera>();
	}
	
	void Update () {
		Matrix4x4 m = new Matrix4x4();
		float width = Screen.width;
		float height = Screen.height;
		float x0 = 0f;
		float y0 = 0f;
		m.m00 = 2f * m00 / width;
		m.m01 = -2f * m01 / width;
		m.m02 = (width - 2f * m02 + 2f * x0) / width;
		m.m03 = 0f;
		m.m10 = 0f;
		m.m11 = 2f * m11 / height;
		m.m12 = (-height + 2f * m12 + 2f * y0) / height;
		m.m13 = 0f;
		m.m20 = 0f;
		m.m21 = 0f;
		m.m22 = (-_camera.farClipPlane - _camera.nearClipPlane) / (_camera.farClipPlane - _camera.nearClipPlane);
		m.m23 = -2f * _camera.farClipPlane * _camera.nearClipPlane / (_camera.farClipPlane - _camera.nearClipPlane);
		m.m30 = 0f;
		m.m31 = 0f;
		m.m32 = -1f;
		m.m33 = 0f;
		_camera.projectionMatrix = m.transpose;
	}
}
