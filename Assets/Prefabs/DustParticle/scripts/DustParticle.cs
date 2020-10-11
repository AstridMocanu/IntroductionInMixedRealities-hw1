using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DustParticle : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject prefab;
    System.Random rnd = new System.Random();
    int lifeSpan = 10;
    GameObject particle;
    public DustParticle(GameObject prefab,Vector3 poz)
    {
     

        particle=Instantiate(prefab, poz, Quaternion.identity);

        /* float r = 0.55f + rnd.Next(0, 3) * 0.1f;
         float g = 0.45f + rnd.Next(0, 3) * 0.1f;
         float b = 0.5f + rnd.Next(0, 3) * 0.1f;
         Color x = new Color(r, g, b);

         SerializedObject halo = new SerializedObject(particle.GetComponent("Halo"));
         halo.FindProperty("m_Color").colorValue = x;
         halo.ApplyModifiedProperties();*/


        Debug.Log("Dust");

    }


 
}
