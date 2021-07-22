using System;
using System.Windows.Forms;
using System.Drawing;

namespace Testing{
    public class Test{
        [STAThread]
        public static void Main(){
            var f = new Form();
            f.Text = "Hello World";

            var l = new Label();
            l.Text = "Name:";
            l.AutoSize = true;
            l.Location = new System.Drawing.Point(10,10);
            f.Controls.Add(l);

            var t = new TextBox();
            t.Location = new System.Drawing.Point(100,10);
            f.Controls.Add(t);

            var b = new Button();
            b.Text = "Submit";
            b.Location = new System.Drawing.Point(200,10);
            f.Controls.Add(b);

            Application.Run(f);
        }
    }
}