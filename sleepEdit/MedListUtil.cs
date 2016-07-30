using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace sleepEditPro
{
	public delegate void medList_Delegate();
	public delegate void removeItemFromList_Delegate(string str);
	class MedListUtil
	{
		private ArrayList list = new ArrayList();
		public medList_Delegate ToLowerCaseDelegate;
		public medList_Delegate RemoveDupDelegate;
		public medList_Delegate RemoveFlagDelegate;
		public removeItemFromList_Delegate removeMedDelegate;
		private string path ="";
		
		public MedListUtil()
		{
			this.ToLowerCaseDelegate  = new medList_Delegate(this.LoadMedList);
			this.ToLowerCaseDelegate += new medList_Delegate(this.toLowerCase);
			this.ToLowerCaseDelegate += new medList_Delegate(this.SaveMedList);
			this.RemoveDupDelegate  = new medList_Delegate(this.LoadMedList);
			this.RemoveDupDelegate += new medList_Delegate(this.removeDup);
			this.RemoveDupDelegate += new medList_Delegate(this.SaveMedList);
			this.RemoveFlagDelegate  = new medList_Delegate(this.LoadMedList);
			this.RemoveFlagDelegate += new medList_Delegate(this.removeFlag);
			this.RemoveFlagDelegate += new medList_Delegate(this.SaveMedList);
			this.removeMedDelegate += new removeItemFromList_Delegate(this.removeMed);		

		}
		private void removeFlag()
		{
			int length =0;
			ArrayList tmplist = new ArrayList();
			foreach (string str in list)
			{
				if (str.EndsWith("*") || str.EndsWith(" "))
				{
					length = str.Length-1;
					tmplist.Add(str.Remove(length,1));
					continue;
				}
				tmplist.Add(str);
			}
			list = tmplist;
		}
		private void toLowerCase()
		{
			ArrayList tmplist = new ArrayList();
			foreach(string str in list)
			{
				tmplist.Add(str.ToLower());					
			}
			list = tmplist;
		}
		private void LoadMedList()
		{
		{
			path = sleepEdit.medPath;
		EXP:
			
			try
			{
				System.IO.StreamReader sr =
					new System.IO.StreamReader(path);
				string input;
				
				// Read as long as there are more lines
				do
				{
					input = sr.ReadLine();
					list.Add(input);
					
				} while (sr.Peek() != -1);
				// Peek returns -1 if at the end of the stream
				// Close the stream
				sr.Close();
				list.Sort();
								
			}
			catch 
			{
				System.Windows.Forms.OpenFileDialog openFileDialog1 = new OpenFileDialog();

				if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					path = openFileDialog1.FileName;
					goto EXP;
				}
				MessageBox.Show("file not found");
								
			}			
		}
		}

		private void SaveMedList()
		{
			try
			{				
				
				System.IO.StreamWriter sw = new
					System.IO.StreamWriter(path);
				foreach (string item in list)
					sw.WriteLine(item); // Write the item to the file
				sw.Flush();
				sw.Close();							
			}
			catch (System.Exception)
			{
				
			}
			MessageBox.Show("Activity Complete!");
		}
		
		private void removeMed(string str)
		{
			this.LoadMedList();
			int i = 0;
			bool notFound = true;
			while ( i < this.list.Count)
			{
				try
				{
					if (list[i].Equals(str))
					{		
						list.RemoveAt(i);
						notFound = false;
					}
					i++;
				}
				catch 
				{
					break;
				}
				
			}
			if(notFound)
				MessageBox.Show("med not found!");
			else
				this.SaveMedList();

		}
		private void removeDup()
		{
			int i = 0;
			while ( i < this.list.Count-1)
			{
				try
				{
					while (list[i].Equals(list[i+1]))
								
						list.RemoveAt(i);				
					i++;
				}
				catch 
				{
					break;
				}
			}			
		}		
	}
}
