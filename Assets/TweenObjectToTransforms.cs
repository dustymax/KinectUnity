using UnityEngine;
using System.Collections;

public class TweenObjectToTransforms : MonoBehaviour {

    public Transform target;
    public Transform[] transforms;

    private int currentTransformIndex = 0;

	private bool isTweening = false;

	void Start()
	{
        if (transforms.Length > 0)
        {
			target.position = transforms[0].position;
			currentTransformIndex = 0;
        }
	}
	
	void Update()
	{
		bool moveToNext = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.RightArrow);
		bool moveToPrev = Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.LeftArrow);
		if (moveToNext || moveToPrev)
		{
			if (moveToNext && currentTransformIndex < transforms.Length - 1)
			{
				currentTransformIndex++;
				isTweening = true;
			}

			if (moveToPrev && currentTransformIndex > 0)
			{
				currentTransformIndex--;
				isTweening = true;
			}
		}

		if (isTweening)
		{
			target.position = Vector3.Lerp(target.position, transforms[currentTransformIndex].position, Time.deltaTime * 2);
			if (Vector3.Distance(target.position, transforms[currentTransformIndex].position) < 0.05)
			{
				isTweening = false;
				target.position = transforms[currentTransformIndex].position;
			}
		}
	}

}
