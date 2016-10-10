using UnityEngine;
using System.Collections;
using thelab.mvc;

public class BoxView : View<TesisApplication> {

	public void OnCollisionEnter(Collision p_collision)
	{
		Notify("box.collision", "Player");
	}
}
