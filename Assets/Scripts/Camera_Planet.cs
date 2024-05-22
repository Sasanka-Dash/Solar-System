using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Planet : MonoBehaviour
{
    Transform Planet;

    public int CurrentPlanet = 0;
    public Transform[] Planets;
    Transform SelfTransform;

    // Start is called before the first frame update
    void Start()
    {
        SelfTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(SelfTransform.position - new Vector3(1,0,0), Planets[CurrentPlanet].position, Time.deltaTime * 10);
        transform.RotateAround(Planets[CurrentPlanet].position, Vector3.up, 20 * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.S))
        {
            SwitchPlanet();
        }
    }

    void SwitchPlanet()
    {
        CurrentPlanet += 1;
        if(CurrentPlanet == Planets.Length)
        CurrentPlanet = 0;
    }
}
