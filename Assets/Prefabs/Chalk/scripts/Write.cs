using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK.Examples
{

    public class Write : MonoBehaviour
    {
        public VRTK_InteractableObject linkedObject;
        private bool isWriting=false;

        private LineRenderer line;

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
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (isWriting)
            {
                line.positionCount++;
                Vector3 poz = transform.position + (0.05f * Vector3.up);
                line.SetPosition(line.positionCount - 1, poz);

            }

        }



        protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
        {
            isWriting = true;
            line = new GameObject().AddComponent<LineRenderer>();
            line.startWidth = 0.03f;
            line.endWidth = 0.03f;

    
            line.material.SetColor("_Color",Color.red);

            line.positionCount = 1;
            Vector3 poz = transform.position + (0.05f * Vector3.up);
            line.SetPosition(0, poz);

        }

        private void InteractableObjectUnused(object sender, InteractableObjectEventArgs e)
        {
            isWriting = false;
        }

    }
}
