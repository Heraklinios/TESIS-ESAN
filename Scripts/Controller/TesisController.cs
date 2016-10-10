using UnityEngine;
using System.Collections;
using thelab.mvc;

public class TesisController : Controller<TesisApplication> {

	public override void OnNotification(string p_event, Object p_target, params object[] p_data)
	{
		switch (p_event) {

		case "box.collision":
			if ((string)p_data [0] == "Player") {
				Log ("Okay");
				app.view.box.gameObject.SetActive (false);

			//if (app.view.box.enabled = false) {
			//	float startTimer = 0;
			//	float timeRespawn = 2;
			//	startTimer += Time.deltaTime;
			//	if (startTimer >= timeRespawn) {
			//		startTimer = 0;
			//		app.view.box.enabled = true;
			//	}
			//}
			


		}
			break;
	
	// Update is called once per frame
	
}
}
}