﻿using Reactor.API.Attributes;
using Reactor.API.Interfaces.Systems;
using Reactor.API.Logging;
using Reactor.API.Runtime.Patching;
using UnityEngine;

namespace Distance.UnlimitedHonk
{
	/// <summary>
	/// The mod's main class containing its entry point
	/// </summary>
	[ModEntryPoint("UnlimitedHonk")]
	public class Mod : MonoBehaviour
	{
		public static Mod Instance { get; private set; }

		public IManager Manager { get; private set; }

		public Log Logger { get; private set; }

		/// <summary>
		/// Method called as soon as the mod is loaded.
		/// WARNING:	Do not load asset bundles/textures in this function
		///				The unity assets systems are not yet loaded when this
		///				function is called. Loading assets here can lead to
		///				unpredictable behaviour and crashes!
		/// </summary>
		public void Initialize(IManager manager)
		{
			// Do not destroy the current game object when loading a new scene
			DontDestroyOnLoad(this);

			Instance = this;

			Manager = manager;

			// Create a log file
			Logger = LogManager.GetForCurrentAssembly();

			Logger.Info("YOU HAVE ENTERED UNLIMITED HONK ZONE");
            Logger.Info("\n --------------------------------------------------------------- \n Mod Ver: 1.00 \n ---------------------------------------------------------------");

            RuntimePatcher.AutoPatch();

            
		}
	}
}



