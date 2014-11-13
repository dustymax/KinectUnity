using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class ColorSourceTextureView : MonoBehaviour
{
    public GameObject ColorSourceManager;

    private ColorSourceManager _ColorManager;
	private GUITexture _GUITexture;

    void Start ()
	{
		_ColorManager = ColorSourceManager.GetComponent<ColorSourceManager>();
		_GUITexture = GetComponent<GUITexture>();
		//_GUITexture.renderer.material.SetTextureScale("_MainTex", new Vector2(-1, 1));
		
		//var newScale = new Vector3();
		//newScale.x = _ColorManager.ColorWidth;
		//newScale.y = _ColorManager.ColorHeight;
		//transform.localScale = newScale;
    }
    
    void Update()
    {
        if (ColorSourceManager == null)
        {
            return;
        }
        
        if (_ColorManager == null)
        {
            return;
        }

		_GUITexture.texture = _ColorManager.GetColorTexture();
		//_GUITexture.texture.
		//_GUITexture.texture.tran
    }
}
