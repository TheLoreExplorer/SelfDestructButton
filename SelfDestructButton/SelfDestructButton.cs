﻿using OWML.Common;
using OWML.ModHelper;
using UnityEngine.InputSystem;

namespace SelfDestructButton
{
    public class SelfDestructButton : ModBehaviour
    {
        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"My mod {nameof(SelfDestructButton)} is loaded!", MessageType.Success);


            // Example of accessing game code.
            LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
            {
                if (loadScene != OWScene.SolarSystem) return;
                ModHelper.Console.WriteLine("Loaded into solar system!", MessageType.Success);

                
            };
        }
        private void Update()
        {
            if (Keyboard.current.uKey.wasPressedThisFrame)
            {
                FindObjectOfType<ShipDamageController>().Explode();


            }
                
            
            


        }
    }
}