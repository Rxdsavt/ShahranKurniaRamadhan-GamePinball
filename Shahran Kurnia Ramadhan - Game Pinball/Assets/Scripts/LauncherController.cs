using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public float maxTimeHold;
    public float maxForce;

    public bool isHold;
    public Collider bola;

    public KeyCode input;
    private Renderer renderer;

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider == bola)
        {
            ReadInput(bola);
        }
    }

    private void ReadInput(Collider col)
    {
        if (Input.GetKey(input) && !isHold)
        {

            StartCoroutine(StartHold(col));

        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        isHold = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
