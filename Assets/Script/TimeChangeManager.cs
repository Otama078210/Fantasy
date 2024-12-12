using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;


public class TimeChangeManager : MonoBehaviour
{
    [SerializeField] GameObject[] lighting;
    [SerializeField] GameObject[] volume;
    [SerializeField] GameObject[] propsObject;
    [SerializeField] Material material;

    [ColorUsage(true, true)]
    [SerializeField] Color[] color;

    bool broken;

    private void Start()
    {
        TimeChange(0);
    }

    public void TimeChange(int time)
    {
        AllInit();

        lighting[time].SetActive(true);
        volume[time].SetActive(true);

        MaterialEmission(time);

        if(lighting[time].transform.parent.gameObject.name == "Broken" && !broken)
        {
            propsObject[0].SetActive(false);
            propsObject[1].SetActive(true);

            broken = true;
        }
        else
        {
            propsObject[1].SetActive(false);
            propsObject[0].SetActive(true);

            broken = false;
        }
    }

    void AllInit()
    {
        for(int i = 0; i < lighting.Length; i++)
        {
            lighting[i].SetActive(false);
        }

        for (int n = 0; n < volume.Length; n++)
        {
            volume[n].SetActive(false);
        }
    }

    void MaterialEmission(int pattern)
    {
        switch (pattern) 
        {
            case 0:
                material.SetColor("_EmissiveColor", color[pattern]);
                break;

            case 1:
                material.SetColor("_EmissiveColor", color[pattern]);
                break;

            case 2:
                material.SetColor("_EmissiveColor", color[pattern]);
                break;

            case 3:
                material.SetColor("_EmissiveColor", color[pattern]);
                break;
        }
    }
}
