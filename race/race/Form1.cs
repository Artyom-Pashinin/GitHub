using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //for Sleep

namespace race
{
    public partial class Form1 : Form
    {
        private List<Car> cars;
        private List<PictureBox> pics;
        private List<Label> labs;
        private string _result;

        public Form1()
        {
            InitializeComponent();
            cars = new List<Car>();
            pics = new List<PictureBox>();
            pics.Add(pictureBox_car_1);
            pics.Add(pictureBox_car_2);
            pics.Add(pictureBox_car_3);
            pics.Add(pictureBox_car_4);
            pics.Add(pictureBox_car_5);
            labs = new List<Label>();
            labs.Add(label_1);
            labs.Add(label_2);
            labs.Add(label_3);
            labs.Add(label_4);
            labs.Add(label_5);
        }

        private void comboBox_cars_in_race_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_start_race.Visible = false;
            comboBox_car_to_bet.Items.Clear();
            foreach (var item in comboBox_cars_in_race.Items)
            {
                if (item != comboBox_cars_in_race.SelectedItem)
                    comboBox_car_to_bet.Items.Add(item);
                else
                {
                    comboBox_car_to_bet.Items.Add(item);
                    break;
                }
            }

            foreach (PictureBox pBox in pics)
                pBox.Visible = false;

            foreach (Label lab in labs)
                lab.Visible = false;

            cars.Clear();

            for (int i = 1; i <= int.Parse(comboBox_cars_in_race.SelectedItem.ToString()); i++)
            {
                pics[i - 1].Visible = true;
                labs[i - 1].Visible = true;
                cars.Add(new Car());
            }
        }

        private void comboBox_car_to_bet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_car_to_bet.SelectedItem!=null && comboBox_stake.SelectedItem != null)
            {
                button_start_race.Visible = true;
            }
        }

        private void comboBox_stake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_car_to_bet.SelectedItem != null && comboBox_stake.SelectedItem != null)
            {
                button_start_race.Visible = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            foreach (PictureBox pBox in pics)
                pBox.Visible = false;

            foreach (Label lab in labs)
                lab.Visible = false;
        }

        private void button_start_race_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= int.Parse(comboBox_cars_in_race.SelectedItem.ToString()); i++)
                {
                    CarMoveAsync(i);
                }
        }

        private void CarMoveAsync(int i)
        {
            Thread loading_thread = new Thread(
            new ThreadStart(() =>
            {
                while (pics[i - 1].Location.X > pictureBox_finish_Line.Location.X)
                {
                    pics[i - 1].Location = new Point(pics[i - 1].Location.X - cars[i - 1].speed, pics[i - 1].Location.Y);
                    Thread.Sleep(30);
                }
            }
            ));
            loading_thread.Start();
        }
    }
}
