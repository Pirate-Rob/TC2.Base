﻿
namespace TC2.Base
{
	public sealed partial class ModInstance: Mod
	{
		protected override void OnRegister(ModContext context)
		{
			Modification.OnInitialize += RegisterModifications;
		}

		protected override void OnInitialize(ModContext context)
		{
			
		}

		protected override void OnConfigure(ModContext context)
		{

		}
	}
}

