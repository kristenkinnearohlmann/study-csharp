using System;
using System.Windows.Forms;
using System.Drawing;

namespace NotePadWindowsForms
{
    public class NotePadWindowsForms: System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button button1;

        public NotePadWindowsForms()
        {
            button1 = new System.Windows.Forms.Button();

            // Button control and its properties
            button1.Location = new System.Drawing.Point(8,32);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(104,32);
            button1.TabIndex = 0;
            button1.Text = "Click me";

            // Adding controls to the form
            Controls.AddRange(new System.Windows.Forms.Control[] {button1} );
            button1.Click += new System.EventHandler (button1_Click);
        }

        // Button click handler
        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Button is clicked");
        }
        public static int Main()
        {
            Application.Run(new NotePadWindowsForms());
            return 0;
        }
    }
}