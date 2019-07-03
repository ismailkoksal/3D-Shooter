using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private int damagePerShot = 20;
    [SerializeField] private float timeBetweenBullets = 0.15f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shotSpawn;
    [SerializeField] private float lifetime = 1f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetButton("Fire1") && timer >= timeBetweenBullets)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        timer = 0f;

        GameObject _bullet = Instantiate(bullet, shotSpawn.position, shotSpawn.rotation) as GameObject;

        AudioManager.instance.Play("PlayerGunShot");

        Destroy(_bullet, lifetime);
    }
}
