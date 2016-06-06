using UnityEngine;
using System.Collections;


[System.Serializable]
public class MainData {
	public static MainData current;
	public GameObject m;
	public GameObject[] hero_slider = new GameObject[4];
	public GameObject[] enemy_slider = new GameObject[4];
	public float px, py;
	public bool battle = false, turn = false, paused = false;
	public int battleTime = 0, battlePhase = 0, choose = 0, avatar_num = 8, izi = 228;
	public static int hero_num = 20, enemy_num = 40, hero_ability_num = 100;
	public int[] curHeroNum = new int[4];
	public int[] curEnemyNum = new int[4];
	public Hero[] hero = new Hero[hero_num];
	public Enemy[] enemy = new Enemy[enemy_num];
	public HeroAbility[] heroAbility = new HeroAbility[hero_ability_num];
	
	void BegTurn() {
		turn = true;
	}
		public MainData ()
		{
				int i;
				for (i = 0; i < hero_num; i++) {
						hero[i] = new Hero(i);
				}
				for (i = 0; i < 4; i++) {
						curHeroNum[i] = i;
				}
				Debug.Log ("MainData constructor");
		}
	void Start () 
	{
			for (int i = 0; i < 4; i++) 
				{
					curHeroNum [i] = i;
				}
		
	}
	void Update () {

	}
}
		










