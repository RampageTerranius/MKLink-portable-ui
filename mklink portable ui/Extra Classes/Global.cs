using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mklink_portable_ui
{
	//used to store global variables and functions used between all forms
	public static class Global
	{
		public static string mode = "";

		public static Form gformMain;
		public static Form gformLink;
		public static Form gformSettings;

		public static bool showCMD;
		public static bool checkIfTargetExists;

		public static List<string> output;

		public static void CreateForms()
		{
			gformMain = new frmMenu();
			gformLink = new frmLink();
			gformSettings = new frmSettings();
			showCMD = true;
			checkIfTargetExists = true;
			output = new List<string>();
		}

		//saving settings to ini as needed
		public static void SaveSettings()
		{			
			if (File.Exists("settings.ini"))
			{
				//setting file exists, load it to memory, edit the memory then save it back to the file
				INI_Editor.INI file = new INI_Editor.INI("settings.ini");

				file.EditValue("Settings", "ShowCMD", showCMD);
				
				//new setting, make sure to update settigns file for old users
				if (file.ValueExists("Settings", "CheckIfTargetExists"))
					file.EditValue("Settings", "CheckIfTargetExists", checkIfTargetExists);
				else
					file.AddValue("Settings", "CheckIfTargetExists", checkIfTargetExists);
				file.SaveAndClose();
			}
				else
			{
				//setting file does not yet exist, create it
				INI_Editor.INI file = new INI_Editor.INI();

				file.AddTree("Settings");
				file.AddValue("Settings", "ShowCMD", showCMD);
				file.AddValue("Settings", "CheckIfTargetExists", checkIfTargetExists);
				file.SaveTo("settings.ini");
			} 
		}

		//loads settings file into memory
		public static void LoadSettings()
		{
			if (File.Exists("settings.ini"))
			{
				INI_Editor.INI file = new INI_Editor.INI("settings.ini");
				showCMD = file.GetValueAsBool("Settings", "ShowCMD");
				if (file.ValueExists("Settings", "CheckIfTargetExists"))
					checkIfTargetExists = file.GetValueAsBool("Settings", "ShowCMD");
			}
		}

		//used when not showing commands to get the output of the error
		private static void processDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
		{
			System.Diagnostics.Process process = sender as System.Diagnostics.Process;

			if (process != null)
				output.Add(e.Data);
		}

		private static void clearDataReceived()
		{
			output = new List<string>();
		}

		private static bool CheckForExisting(string location)
		{
			if (!checkIfTargetExists)
				return true;

			bool value = false;

			if (File.Exists(location) || Directory.Exists(location))
				value = true;
			

			return value;  
		}


		//used to run mklink
		public async static void RunCMD(string location, string target)
		{
			//check if the file exists (if we have the settign enabled)
			if (!CheckForExisting(target))
			{
				MessageBox.Show("Command Failed!\n" +
								"The target does not exist!\n" +
								"Check Target path or change Check If Target Exists in settings.", "Info", MessageBoxButtons.OK);
				return;
			}

			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.FileName = "cmd.exe";//the process we will be starting

			//if not showing the CMD.exe box then we need to intercept all text to show in the success/failure box
			if (!showCMD)
			{
				startInfo.RedirectStandardOutput = true;
				startInfo.RedirectStandardError = true;
				startInfo.UseShellExecute = false;
				startInfo.CreateNoWindow = true;

				process.OutputDataReceived += processDataReceived;
				process.ErrorDataReceived += processDataReceived;
				clearDataReceived();
			}

			//preparing any extra parameters required for the process
			string type = "";						
			switch(mode)
			{
				case "DirSymLink":
					type = "/d ";
					break;

				case "HardLink":
					type = "/h ";
					break;

				case "DirJunk":
					type = "/j ";
					break;
			}

			string arg;

			if (showCMD)
				arg = "/k mklink ";
			else
				arg = "/c mklink ";

			arg += type +  "\"" +location + "\" \"" + target + "\"";
			startInfo.Arguments = arg;  
			process.StartInfo = startInfo;

			if (showCMD)
				process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;			
			else			
				process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			
				

			process.Start();


			//show if process succeeded
			if (!showCMD)
			{
				//begin processing the data from the command line
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();

				//wait for the cmd to finish running
				//with out this line program attempts to access data before the process has exited if NOT showing the command box
				while (!process.HasExited)
					await Task.Delay(1000);				

				if (process.ExitCode == 0)
				{
					process.Close();
					string str = "Success!";
					foreach (string s in output)					
						if (s != "")
							str += "\n" + s;
					
					MessageBox.Show(str, "Info", MessageBoxButtons.OK);
				}
					
				else if (process.ExitCode == 1)
				{
					process.Close();
					string str = "Command Failed!";
					foreach (string s in output)
						if (s != "")
							str += "\n" + s;

					MessageBox.Show(str, "Info", MessageBoxButtons.OK);
				}
					
			}
		}
	}
}