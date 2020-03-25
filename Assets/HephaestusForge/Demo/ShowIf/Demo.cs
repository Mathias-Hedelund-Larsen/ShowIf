using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HephaestusForge.ShowIf
{
    public class Demo : MonoBehaviour
    {
        [SerializeField, ShowIf]
        private int _tVal;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}