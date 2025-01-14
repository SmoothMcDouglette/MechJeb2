﻿using System;
using UnityEngine;

namespace MuMech
{
	public class MechJebModuleScriptActionPause : MechJebModuleScriptAction
	{
		public static String NAME = "Pause";

		public MechJebModuleScriptActionPause (MechJebModuleScript scriptModule, MechJebCore core, MechJebModuleScriptActionsList actionsList):base(scriptModule, core, actionsList, NAME)
		{
		}

		public override void activateAction()
		{
			base.activateAction();
		}

		public override  void endAction()
		{
			base.endAction();
		}

		public override void WindowGUI(int windowID)
		{
			base.preWindowGUI(windowID);
			base.WindowGUI(windowID);
			GUILayout.Label ("Pause");
			if (this.isStarted())
			{
				if (GUILayout.Button ("GO"))
				{
					this.endAction ();
				}
			}
			base.postWindowGUI(windowID);
		}
	}
}

