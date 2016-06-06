using UnityEngine;
using System.Collections;

[System.Serializable]

public class Hero {
		public int health = 50, mana, maxHealth= 50, defense, mdefense, attack, mattack, speed = 5, num;
		public float battleTime;
		public int[] relation, resist;
		public Sprite avatar;
		//public Object avatar;
		public void setBattleTime(int a)
		{
				battleTime = a;
		}
		public Hero(int mynum){
				Debug.Log ("Hero constructor");
				num = mynum;
				if (Resources.Load<Sprite> ("avatar/avatar" + num.ToString ()) != null) {
						avatar = Resources.Load<Sprite> ("avatar/avatar" + num.ToString ());
						Debug.Log ("Avatar loaded" + num.ToString ());
				} else 
				{
						Debug.Log ("Avatar not found " + num.ToString ());
				}
		}

}

public class Enemy {
		public int health, mana, maxHealth, defense, mdefense, attack, mattack, speed, battleTime, num;
		public int[] relation, resist;
		Enemy(){
				for (int i = 0; i < 20; i++)
				{
						resist[i] = 0;
				}
		}
}

public class HeroAbility {
		private int manacost, damage, castTime;
}

public class Item {
		private int cost;
}
