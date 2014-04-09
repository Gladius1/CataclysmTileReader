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
    public partial class Tileset_Checker : Form
    {
        string jsonLocation, tileLocation, json, filepath;
        StreamReader sr1;
        JArray array;
        List<String> writing, jsonFiles, tileID;

        public Tileset_Checker()
        {
            InitializeComponent();
            jsonLocation = jsonfolderBox.Text;
            tileLocation = tileconfigBox.Text;
            
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
            jsonFiles.Add(@"bionics.json");
            jsonFiles.Add(@"furniture.json");
            jsonFiles.Add(@"monsters.json");
            jsonFiles.Add(@"terrain.json");
            jsonFiles.Add(@"vehicle_parts.json");
        }

        private void tileconfigButton_Click(object sender, EventArgs e)
        {
            DialogResult tile = tileconfigDiag.ShowDialog();
            if (tile == DialogResult.OK)
            {
                tileLocation = tileconfigDiag.FileName;
                tileconfigBox.Text = tileconfigDiag.FileName;
            }
        }

        private void jsonfolderButton_Click(object sender, EventArgs e)
        {
            DialogResult json = jsonfolderDiag.ShowDialog();
            if (json == DialogResult.OK)
            {
                jsonLocation = jsonfolderDiag.SelectedPath + @"\";
                jsonfolderBox.Text = jsonfolderDiag.SelectedPath + @"\";
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (jsonLocation == null || tileLocation == null)
            {
                MessageBox.Show(@"Error! Please point the program to both your tile_config.json and your \data\json\ folder");
            }
            else
            {
                writing = new List<string>();
                status.Text = "Status: Reading tile_config.json";
                sr1 = new StreamReader(tileLocation);
                JsonReader reader = new JsonTextReader(sr1);
                JObject o1 = (JObject)JToken.ReadFrom(reader);
                reader.Close();
                sr1.Close();
                array = (JArray)o1["tiles"];
                reader.Close();
                tileID = new List<string>();
                for (int i = 0; i < array.Count; i++)
                {
                    tileID.Add((string)array[i]["id"]);
                }
                foreach (String s in jsonFiles)
                {
                    status.Text = "Status: Reading " + s;
                    filepath = jsonLocation + s;
                    Console.WriteLine(filepath);
                    sr1 = new StreamReader(filepath);
                    json = sr1.ReadToEnd();
                    sr1.Close();
                    array = JArray.Parse(json);
                    for (int i = 0; i < array.Count; i++)
                    {
                        bool found = false;
                        string id = (string)array[i]["id"];
                        if ((string)array[i]["type"] == "vehicle_part")
                        {
                            id = "vp_" + id;
                        }
                        foreach (string s1 in tileID)
                        {
                            if (!found)
                            {
                                if (s1 == id)
                                {
                                    found = true;
                                }
                            }                            
                        }
                        if (!found)
                        {
                           writing.Add(id);
                        }
                    }
                }
                //Now to write the missing.txt
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    status.Text = "Status: Writing missing.txt";
                    File.WriteAllText(saveFile.FileName, "");
                    StreamWriter writer = new StreamWriter(saveFile.FileName);
                    foreach (string s in writing)
                    {
                        writer.WriteLine(s);
                    }
                    writer.Close();
                }
                status.Text = "Status: Done!";
            }
        }

        private void tileconfigDiag_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
