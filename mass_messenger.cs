using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Mass_Messenger{
    class window{
        List<string> CC_Emails;
        List<string> BCC_Emails;
        string To_Email;
        string From_Email;
        Button Create_Button(int x,int y,int w ,string title,int sub_function){
            var Temp = new Button();
            Temp.Location = new Point(x,y);
            Temp.Width = w;
            Temp.Text = title;
            Temp.Click += delegate(object s, EventArgs e) {Sub_Choice(s, e, sub_function);};
            return Temp;
        }
        Label Create_Label(int x, int y,int w, string text){
            var Temp = new Label();
            Temp.Location = new Point(x,y);
            Temp.Width = w;
            Temp.Text = text;
            return Temp;
        }
        TextBox Create_TextBox(int x, int y, int w){
            var Temp = new TextBox();
            Temp.Location = new Point(x,y);
            Temp.Width = w;
            return Temp;
        }
        public Form create_form(){
            var form = new Form();
            form.Text = "Mass_Messanger v 0.1.0";
            form.Controls.Add(Create_Label(10,10,30,"Name"));
            form.Controls.Add(Create_TextBox(30,10,100));
            form.Controls.Add(Create_Button(130,10,50,"test_2?",1));
            form.Controls.Add(Create_Button(180,10,50,"Submit?",0));
            return form;
        }
        void Sub_Choice(object s, EventArgs e, int n){
            switch(n){
                case(0):
                    Button_Import();
                    break;
                case(1):
                    Console.WriteLine("darn");
                    break;
                default:
                    Console.WriteLine("how did you get here");
                    break;
            }
        }
        string Get_FilePath(){
            OpenFileDialog dlg = new OpenFileDialog();
            string fileName;
             if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                Console.WriteLine("{0}",fileName);
                return fileName;
            }
            return "";
        }
        class InvalidFilePath : Exception{
            public InvalidFilePath(){

            }
        }
        void IsFilepath(string filepath){
            if (filepath == ""){
                throw new InvalidFilePath();
            }
        }
        void Button_Import(){
            string filepath = "";
            try {
                filepath = Get_FilePath();
                IsFilepath(filepath);
            }
            catch(InvalidFilePath e){
                Console.WriteLine("No file selected!");
            }
            Console.WriteLine("success: {0}",filepath);
        }

    }
    class main{
        static void Main(){
            var Win = new window();
            Application.Run(Win.create_form());
        }
    }
}