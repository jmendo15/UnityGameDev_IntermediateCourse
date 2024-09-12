using UnityEngine;

public class BouncyWall : MonoBehaviour
{
	public int bumperForce = 800;
	private GameObject player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject == player)
		{
			player.GetComponent<Rigidbody>().AddExplosionForce(bumperForce, collision.contacts[0].point, 1);
		}
	}
}