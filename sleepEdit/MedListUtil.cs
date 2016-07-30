using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace sleepEditPro
{
    public delegate void medList_Delegate();

    public delegate void removeItemFromList_Delegate(string str);

    internal class MedListUtil
    {
        private ArrayList list = new ArrayList();
        private string path = "";
        public medList_Delegate RemoveDupDelegate;
        public medList_Delegate RemoveFlagDelegate;
        public removeItemFromList_Delegate removeMedDelegate;
        public medList_Delegate ToLowerCaseDelegate;

        public MedListUtil()
        {
            ToLowerCaseDelegate = LoadMedList;
            ToLowerCaseDelegate += toLowerCase;
            ToLowerCaseDelegate += SaveMedList;
            RemoveDupDelegate = LoadMedList;
            RemoveDupDelegate += removeDup;
            RemoveDupDelegate += SaveMedList;
            RemoveFlagDelegate = LoadMedList;
            RemoveFlagDelegate += removeFlag;
            RemoveFlagDelegate += SaveMedList;
            removeMedDelegate += removeMed;
        }

        private void removeFlag()
        {
            var length = 0;
            var tmplist = new ArrayList();
            foreach (string str in list)
            {
                if (str.EndsWith("*") || str.EndsWith(" "))
                {
                    length = str.Length - 1;
                    tmplist.Add(str.Remove(length, 1));
                    continue;
                }
                tmplist.Add(str);
            }
            list = tmplist;
        }

        private void toLowerCase()
        {
            var tmplist = new ArrayList();
            foreach (string str in list)
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
                    var sr =
                        new StreamReader(path);
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
                    var openFileDialog1 = new OpenFileDialog();

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
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
                var sw = new
                    StreamWriter(path);
                foreach (string item in list)
                    sw.WriteLine(item); // Write the item to the file
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {
            }
            MessageBox.Show("Activity Complete!");
        }

        private void removeMed(string str)
        {
            LoadMedList();
            var i = 0;
            var notFound = true;
            while (i < list.Count)
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
            if (notFound)
                MessageBox.Show("med not found!");
            else
                SaveMedList();
        }

        private void removeDup()
        {
            var i = 0;
            while (i < list.Count - 1)
            {
                try
                {
                    while (list[i].Equals(list[i + 1]))

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