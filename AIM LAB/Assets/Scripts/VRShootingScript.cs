using UnityEngine;

public class VRShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public GameObject muzzleFlashPrefab; // New variable for the muzzle flash
    
    public float shootingInterval = 0.5f;

    

    public void Shoot()
    {
        // Create a bullet object
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // Get the rigidbody of the bullet object
        //Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        // Apply forward force to the bullet
       // bulletRigidbody.velocity = bulletSpawnPoint.forward * bulletSpeed;

        // Destroy the bullet after a certain time to avoid cluttering the scene
        Destroy(bullet, 5f);

        // Create the muzzle flash object
        GameObject muzzleFlash = Instantiate(muzzleFlashPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // Destroy the muzzle flash after a short delay
        Destroy(muzzleFlash, 0.1f);
    }
}
