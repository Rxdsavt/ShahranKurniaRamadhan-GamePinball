using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    private Renderer renderer;
    private Animator animator;

    public float score = 1;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        renderer.material.color = color;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
            animator.SetTrigger("Hit");

            audioManager.PlaySFXBumper(collision.transform.position);
            vfxManager.PlayVFXBumper(collision.transform.position);
            scoreManager.AddScore(score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
