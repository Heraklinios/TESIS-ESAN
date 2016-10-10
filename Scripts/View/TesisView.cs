using UnityEngine;
using System.Collections;
using thelab.mvc;
public class TesisView : View<TesisApplication> {

	public BoxView box { 
		get { 
			return m_box = Assert<BoxView>(m_box); 
		} 
	}
	private BoxView m_box;



}
