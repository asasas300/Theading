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

namespace Theading
{
    public partial class FrmBasicThread : Form
    {
            Thread ThreadA;
            Thread ThreadB;

            public FrmBasicThread()
            {
                InitializeComponent();
            }

            private void btnRun_Click(object sender, EventArgs e)
            {
                // Update UI label to indicate threads are starting
                this.lblStatus.Text = "-Before starting thread-";
                Console.WriteLine(this.lblStatus.Text);

                // Create and name the threads
                ThreadA = new Thread(MyThreadClass.Thread1);
                ThreadA.Name = "Thread A";

                ThreadB = new Thread(MyThreadClass.Thread1);
                ThreadB.Name = "Thread B";

                // Start the threads
                ThreadA.Start();
                ThreadB.Start();

                // Wait for both threads to finish
                ThreadA.Join();
                ThreadB.Join();

                // Once threads are finished, update the UI label
                this.lblStatus.Text = "-End of Thread-";
                Console.WriteLine(this.lblStatus.Text);
            }
        }
}

       