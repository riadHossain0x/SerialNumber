﻿//========================================================================
// This conversion was produced by the Free Edition of
// Instant C# courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace SerialNumber
{
	namespace Properties
	{

		[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute(), global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal sealed partial class Settings : System.Configuration.ApplicationSettingsBase
		{
			private static Settings defaultInstance = (Settings)global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings());

#region My.Settings Auto-Save Functionality
#if WINDOWSFORMS
			private static bool addedHandler;

			private static object addedHandlerLockObject = new object();

			[global::System.Diagnostics.DebuggerNonUserCodeAttribute(), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
			private static void AutoSaveSettings(global::System.Object sender, global::System.EventArgs e)
			{
				if (My.MyApplication.Application.SaveMySettingsOnExit)
				{
					defaultInstance.Save();
				}
			}
#endif
#endregion

			public static Settings Default
			{
				get
				{

#if WINDOWSFORMS
					   if (!addedHandler)
					   {
							lock (addedHandlerLockObject)
							{
								if (!addedHandler)
								{
									My.MyApplication.Application.Shutdown += new Microsoft.VisualBasic.ApplicationServices.ShutdownEventHandler(AutoSaveSettings);
									addedHandler = true;
								}
							}
						}
#endif
					return defaultInstance;
				}
			}
		}
	}

//INSTANT C# NOTE: This block was only required to support 'My.Settings' in VB. 'Properties.Settings' is used in C#:
//Namespace My
//
//	<Microsoft.VisualBasic.HideModuleNameAttribute(), global::System.Diagnostics.DebuggerNonUserCodeAttribute(), global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()> Friend Module MySettingsProperty
//
//		<global::System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")> Friend ReadOnly Property Settings() As SerialNumber.My.MySettings
//			Get
//				return SerialNumber.My.MySettings.Default
//			End Get
//		End Property
//	End Module
//End Namespace

}