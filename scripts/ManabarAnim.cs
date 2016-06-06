using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManabarAnim : MonoBehaviour {
		public static int spr_num = 60,j = 0;
		public Sprite[] spr = new Sprite[spr_num];
	// Use this for initialization
	void Start () {
					for (int i = 0; i < spr_num; i++)
						if (Resources.Load<Sprite> ("manabar/manabar (" + i.ToString ()+")") != null) 
						{
						spr[i] = Resources.Load<Sprite> ("manabar/manabar (" + i.ToString ()+")");
						Debug.Log ("Manabar loaded" + i.ToString ());
						}
						else
								Debug.Log ("Manabar not loaded" + i.ToString ());	



						
				  }
	
	// Update is called once per frame
	void Update () 
		{
				Image im = GetComponent<Image>();
				if (j < spr_num - 1) 
				{
						j++;
				} else 
				{
						j = 0;
				}
				im.sprite = spr [j];
	}
}
