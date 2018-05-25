using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DialogBox
{
    public partial class PlayerInfo : Form
    {
        public string[] name = new string[100];
        public int[] score = new int[100];
        public string[] date = new string[100];

        public PlayerInfo()
        {
            InitializeComponent();
        }

        private void PlayerInfo_Load(object sender, EventArgs e)
        {
            StreamReader str;
            
            int count = 0;


            char[] delimiter = { ',' };




            str = File.OpenText("../../PlayerInfo.csv");



            while (!str.EndOfStream)
            {
                string line = str.ReadLine();



                string[] tokens = line.Split(delimiter);

                name[count] = tokens[0];
                score[count] = int.Parse(tokens[2]);
                date[count] = tokens[1];
                PlayersListBox.Items.Add(name[count]);

                count++;




            }


            str.Close();

           // PlayersListBox.DataSource = name;

        }

        private void PlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScoreLabel.Text = score[PlayersListBox.SelectedIndex].ToString();
            DateLabel.Text = date[PlayersListBox.SelectedIndex];

        }

        private void AddPlayerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PlayersListBox.Items.Add(AddPlayerTextBox.Text);


                AddPlayerTextBox.Clear();
            }

        }
    }
}




 




   


       

        
    


    

            
        
    


