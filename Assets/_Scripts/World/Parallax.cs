using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private float lenght, startposX, startposY, startPosZ;
    public GameObject camera;
    public float parallaxEffect;


    // Start is called before the first frame update
    void Start()
    {
        startposX = transform.position.x;
        startposY = transform.position.y;
        startPosZ = transform.position.z;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float temp = (camera.transform.position.x * (1 - parallaxEffect));
        float distX = (camera.transform.position.x * parallaxEffect);
        float distY = (camera.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startposX + distX, startposY, transform.position.z);

        if (temp > startposX + lenght)
        {
            startposX += lenght;
        }
        else if (temp < startposX - lenght)
        {
            startposX -= lenght;
        }
    }

    //should work with vertical und horizontal parallax but it doesnt
    //public Transform[] backgrounds;
    //public float smoothing = 1f;

    //private float[] parallaxScales;
    //private Transform cam;
    //private Vector3 previousCamPos;

    //private void Awake()
    //{
    //    cam = Camera.main.transform;
    //}

    //private void Start()
    //{
    //    previousCamPos = cam.position;

    //    parallaxScales = new float[backgrounds.Length];

    //    for (int i = 0; i < backgrounds.Length; i++)
    //    {
    //        parallaxScales[i] = backgrounds[i].position.z * -1;
    //    }
    //}


    //private void Update()
    //{
    //    for (int i = 0; i < backgrounds.Length; i++)
    //    {
    //        float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

    //        float backgroundTargetPosX = backgrounds[i].position.x + parallax;
    //        Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

    //        backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
    //    }

    //    previousCamPos = cam.position;
    //}
}
