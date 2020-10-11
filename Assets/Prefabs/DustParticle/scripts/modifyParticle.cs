using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class modifyParticle : MonoBehaviour
{
    System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



     
        int probabilit = rnd.Next(1000);
        if (probabilit % 4 == 0) ChangeColor();
        if (probabilit % 7 == 0) ChangePosition();

    }


    public void ChangeColor()
    {

        float r = 0.2f + rnd.Next(0, 100) * 0.006f;
        float g = 0.25f + rnd.Next(0, 100) * 0.006f;
        float b = 0.2f + rnd.Next(0, 100) * 0.006f;
        Color x = new Color(r, g, b);

        SerializedObject halo = new SerializedObject(GetComponent("Halo"));
        halo.FindProperty("m_Color").colorValue = x;
        halo.ApplyModifiedProperties();
    }
    public void ChangePosition()
    {
        float pozx = ((float)rnd.NextDouble() - 0.5f) / 20f;
        float pozy = ((float)rnd.NextDouble() - 0.5f) / 20f;
        float pozz = ((float)rnd.NextDouble() - 0.5f) / 20f;
        transform.Translate (new Vector3(pozx, pozy, pozz));


    }
}
