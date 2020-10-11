
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK.Examples
{

    public class MagicWandScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public VRTK_InteractableObject linkedObject;
        public GameObject dust;
        public bool isDust=false;
        public float sparkleLife = 5f;
        System.Random rnd = new System.Random();
        public GameObject prefab;

        protected virtual void OnEnable()
        {
            linkedObject = (linkedObject == null ? GetComponent<VRTK_InteractableObject>() : linkedObject);

            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed += InteractableObjectUsed;
                linkedObject.InteractableObjectUnused += InteractableObjectUnused;
            }
        }

    

        protected virtual void OnDisable()
        {
            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed -= InteractableObjectUsed;
            }
        }

        private void Update()
        {
            
            if (isDust)
            {
               
                float pozx = ((float)rnd.NextDouble() - 0.5f)/2f;
                float pozy = ((float)rnd.NextDouble()-0.4f)/2f;
                float pozz = ((float)rnd.NextDouble()-0.5f)/2f;

                
              
               
                Transform wandPosition = GameObject.Find("Wand").transform;
                DustParticle particle = new DustParticle(prefab,new Vector3(pozx,pozy,pozz)+wandPosition.position);
         //       GameObject.Find("Wand").transform.position=new Vector3(1,1,1);
            }
        }

        protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
        {
            isDust = true;
            GameObject.Find("Wand").GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
        }

        private void InteractableObjectUnused(object sender, InteractableObjectEventArgs e)
        {
            isDust = false;
        }


    }
}


