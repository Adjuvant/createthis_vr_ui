﻿using UnityEngine;
using CreateThis.Factory;

namespace CreateThis.VR.UI {
    public class VRUI_Defaults : MonoBehaviour {
        public PanelProfile panelProfile;

        void OnValidate() {
            if (panelProfile != null) FactoryDefaults.panel = panelProfile;
        }

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
    }
}