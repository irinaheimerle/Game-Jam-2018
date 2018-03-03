using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Earth : MonoBehaviour
{

	public ParticleSystem impactPart;
	public int hitCount = 0;
	public GameObject gameOverScreen;
	public Text txtGameOver;

	public void AsteroidHit(GameObject hit)
	{
		hitCount += 1;


		Debug.Log("hi");
		Debug.Log(hitCount);

		//ParticleSystem cloneImpact = ParticleSystem.Instantiate(impactPart);
		//cloneImpact.transform.position = hit.transform.position;

		//cloneImpact.GetComponent<GameObject_Destroyer> ().DestroyMe ();
		hit.GetComponent<GameObject_Destroyer>().DestroyMe();

		if (hitCount == 2)
		{
			Terrain_Manager.ChangeState(Terrain_Manager.State.Mid);
		}
		else if (hitCount == 3)
		{
			Terrain_Manager.ChangeState(Terrain_Manager.State.Dead);
			gameOverScreen.SetActive(true);
			Game_Manager.ChangeState(Game_Manager.State.Game_Over);
			txtGameOver.text = Score_Manager.CurrentScore.ToString();

		}
	}
}