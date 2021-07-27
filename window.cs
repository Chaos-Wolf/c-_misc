using System;
using System.Windows.Forms;
using System.Drawing;

namespace Testing{
    public class Test{
        [STAThread]
        public Button Create_Button(int x,int y,string text,int n){
            Button Temp = new Button();
            Temp.Location = new System.Drawing.Point(x,y);
            Temp.Text = text;
            Temp.Click += delegate(object s, EventArgs e) {Sub_Choice(s, e, n);};
            return Temp;
        }
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
            
            Test new_button = new Test();
            f.Controls.Add(new_button.Create_Button(200,10,"test_2?",1));
            f.Controls.Add(new_button.Create_Button(300,10,"Submit?",0));
            

            Application.Run(f);
        }
        private static void Sub_Choice(object s,EventArgs e,int n){
            Test temp = new Test();
            switch(n){
                case 0:
                    temp.Test_print();
                    break;
                case 1:
                    temp.Test_print2();
                    break;
                default:
                    break;
            }
        }
        public void Test_print(){
            Console.WriteLine("this is a test");
        }
        public void Test_print2(){
            Console.WriteLine("nothing is safe from my jank");
        }
    }
}