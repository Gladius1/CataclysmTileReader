using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CataclysmTileReader
{
    public partial class Form2 : Form
    {
        public string gfxFolderResult, tileFolderResult, jsonFolderResult, filepath;
        public StreamReader sr1, sr2;
        public JsonTextReader reader1, reader2;
        public JObject obj1, obj2;
        public JArray arr1, arr2;
        public List<String> lis1, lis2, writing, jsonFiles;
        public Form2()
        {
            InitializeComponent();
            gfxFolderResult = @"C:\Cata\gfx\";
            tileFolderResult = @"C:\Cata\gfx\TsuTileset\";
            jsonFolderResult = @"C:\Cata\data\json\";
            obj1 = null;
            //Create List of all Json Files to be scanned
            jsonFiles = new List<string>();
            jsonFiles.Add(@"items\ammo.json");
            jsonFiles.Add(@"items\archery.json");
            jsonFiles.Add(@"items\armor.json");
            jsonFiles.Add(@"items\books.json");
            jsonFiles.Add(@"items\comestibles.json");
            jsonFiles.Add(@"items\containers.json");
            jsonFiles.Add(@"items\instruments.json");
            jsonFiles.Add(@"items\melee.json");
            jsonFiles.Add(@"items\mods.json");
            jsonFiles.Add(@"items\ranged.json");
            jsonFiles.Add(@"items\tools.json");
            jsonFiles.Add(@"items\vehicle_parts.json");
            jsonFiles.Add(@"vehicle_parts.json");
        }

        private void gfxBrowse_Click(object sender, EventArgs e)
        {
            DialogResult gfx = gfxFolder.ShowDialog();
            if (gfx == DialogResult.OK)
            {
                gfxFolderResult = gfxFolder.SelectedPath + @"\";
                gfxBox.Text = gfxFolderResult;
            }
        }

        private void tileBrowse_Click(object sender, EventArgs e)
        {
            DialogResult tile = tileFolder.ShowDialog();
            if (tile == DialogResult.OK)
            {
                tileFolderResult = tileFolder.SelectedPath + @"\";
                tileBox.Text = tileFolderResult;
            }
        }

        private void jsonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult json = jsonFolder.ShowDialog();
            if (json == DialogResult.OK)
            {
                jsonFolderResult = jsonFolder.SelectedPath + @"\";
                jsonBox.Text = jsonFolderResult;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (gfxFolderResult == null || jsonFolderResult == null)
            {
                MessageBox.Show("Error! Please point the program to your /gfx/ folder and your /data/json/ folder");
            }
            else
            {
                
                writing = new List<string>();
                
                //Scan all the relevant jsonFiles
                /*foreach (string s in jsonFiles)
                {
                    progressText.Text = "Scanning: " + s;
                    filepath = jsonFolderResult + s;
                    Console.WriteLine(filepath);
                    sr1 = new StreamReader(filepath);
                    string json = sr1.ReadToEnd();
                    arr1 = JArray.Parse(json);
                    for (int i = 0; i < arr1.Count; i++)
                    {
                        string stemp = (string)arr1[i]["id"];
                        Console.WriteLine((string)arr1[i]["type"]);
                        if ((string)arr1[i]["type"] == "vehicle_part")
                        {
                            stemp = "vp_" + stemp;
                        }
                        writing.Add(stemp);
                        Console.WriteLine(stemp);
                    }
                    sr1.Close();*/
                
                //Write the JSON to a new masterlist.
                /*
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.WriteStartObject();
                    writer.WriteToken(
                    writer.WritePropertyName("height");
                    writer.WriteValue("16");
                    
                    writer.WriteEnd();
                    writer.WriteEndObject();
                }
                System.IO.File.WriteAllText(gfxFolderResult + @"neWtile_config.json", string.Empty);
                StreamWriter file = new StreamWriter(gfxFolderResult + @"neWtile_config.json");
                file.Write(sb.ToString());
                file.Close();*/
                JObject o =
                    new JObject(
                        new JProperty("tile_info",
                            new JArray(
                                new JObject(
                                    new JProperty("height", 16),
                                    new JProperty("width", 16)))));
                File.WriteAllText(@"c:\test.json", o.ToString());
            }
        }
    }
}
