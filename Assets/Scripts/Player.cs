using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	[SerializeField] float maxHp;
	public float hp;

	void Start()
	{
		hp = maxHp;
	}

	public void TakeDamage(float dmg)
	{
		hp -= dmg;
		if (hp <= 0) Die();
	}

	void Die()
	{
		Debug.Log("YOU DIED");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
