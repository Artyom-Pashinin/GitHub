using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shipApp
{
    public partial class Form1 : Form
    {
        List<Label> loading_queue;
        List<ProgressBar> loading_queue_pb;

        public Form1()
        {
            InitializeComponent();
            loading_queue = new List<Label>();
            loading_queue.Add(ship1_label);
            loading_queue.Add(ship2_label);
            loading_queue.Add(ship3_label);
            loading_queue.Add(ship4_label);
            loading_queue.Add(ship5_label);
            loading_queue_pb = new List<ProgressBar>();
            loading_queue_pb.Add(ship1_progressBar);
            loading_queue_pb.Add(ship2_progressBar);
            loading_queue_pb.Add(ship3_progressBar);
            loading_queue_pb.Add(ship4_progressBar);
            loading_queue_pb.Add(ship5_progressBar);
        }

        private void addToQueue_button_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty)
            {
                add_ship(comboBox1.Text);
            }
        }

        private int get_free_place()
        {
            for (int i=0; i<loading_queue.Count ; i++)
            {
                if (loading_queue[i].Text == " ")
                {
                    return i;
                }
            }
            return -1;
        }

        private void add_ship(string ship_name)
        {
            int free_place = get_free_place();
            if (free_place != -1)
            {
                loading_queue[free_place].Text = ship_name;
                loading_queue_pb[free_place].Value = 0;
                loading_ship_cargo(free_place);
            }
        }

        private void loading_ship_cargo(int free_place)
        {
            Thread loading_thread = new Thread(
            new ThreadStart(() =>
            {
            for (int n = 0; n < 100; n++ )
            {
                Thread.Sleep(100);
                loading_queue_pb[free_place].Value = n;
            }

            loading_queue[free_place].Text = " ";
            loading_queue_pb[free_place].Value = 0;
            }
            ));
            loading_thread.Start();
        }
    }
}
