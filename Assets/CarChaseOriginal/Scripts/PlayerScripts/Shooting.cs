using UnityEngine;
using TMPro;
public class Shooting : MonoBehaviour
{
    //
    public float damage = 10f;
    public float range = 100f;
    public float Force = 30f;
    //Reference to 
    public Camera fpscam;
    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
    public ParticleSystem particles;
    public GameObject impacteffect;

    //scoring
    private int score = 0;
    public TextMeshProUGUI scoreText;

    //GameWin
    public TextMeshProUGUI Win;
    //CountDownTimer timerobj = new CountDownTimer();
    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        scoring();
        if(Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time * 1f / fireRate;
            Shoot();
        }
        
    }

    private void Shoot()
    {
        particles.Play();
        //we will store the information of with which we hit 
        RaycastHit hit;
        //shoot out the ray 
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            TargetShooting Target = hit.transform.GetComponent<TargetShooting>();
            if(Target != null)
            {
                Target.TakeDamage(damage);
                if(Target.health <= 0)
                {
                    UpdateScore(1);
                }
            }
           
           if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * Force);
            }
            GameObject impactGO = Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
        
    }
    private void scoring()
    {
        scoreText.text = "score:" + score;
    }
    private void UpdateScore(int addscore)
    {
        score += addscore;
        scoring();
    }

    

}
