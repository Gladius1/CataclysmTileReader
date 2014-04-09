using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CataclysmTileReader
{
    public partial class Form1 : Form
    {
        public StreamReader sr1, sr2;
        public JsonTextReader source, compare;
        public JObject o1, o2;
        public JArray a1, a2;
        public List<String> oid, cid, missing;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (originalFile.ShowDialog() == DialogResult.OK)
            {
                sr1 = new StreamReader(originalFile.FileName);
                sourceText.Text = originalFile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (compareFile.ShowDialog() == DialogResult.OK)
            {
                sr2 = new StreamReader(compareFile.FileName);
                compareText.Text = compareFile.FileName;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            source = new JsonTextReader(sr1);
            compare = new JsonTextReader(sr2);
            o1 = (JObject)JToken.ReadFrom(source);
            o2 = (JObject)JToken.ReadFrom(compare);
            a1 = (JArray)o1["tiles"];
            a2 = (JArray)o2["tiles"];
            oid = new List<string>();
            cid = new List<string>();
            missing = new List<string>();
            for (int i = 0; i < a1.Count; i++)
            {
                String stemp = (string)a1[i]["id"];
                oid.Add(stemp);
            }
            for (int i = 0; i < a2.Count; i++)
            {
                String stemp = (string)a2[i]["id"];
                cid.Add(stemp);
            }
            foreach (string cs in cid)
            {
                bool found = false;
                foreach (string os in oid)
                {
                    if (String.Equals(cs,os))
                    {
                        //Console.WriteLine(os + " Found!");
                        found = true;
                    }
                }
                if (!found)
                {
                    missing.Add(cs);
                }
            }
            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                System.IO.File.WriteAllText(saveFile.FileName, string.Empty);
                StreamWriter file = new StreamWriter(saveFile.FileName);
                foreach (string s in missing)
                {
                    file.WriteLine(s);
                }
                file.Close();
                sr1.Close();
                sr2.Close();
                Application.Exit();
            }
        }
    }
}
