using UnityEngine;
using UnityEngine.UI;

public class FireButton : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public void Fire()
    {
        // Instantiate a bullet at the fire point
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }
}
