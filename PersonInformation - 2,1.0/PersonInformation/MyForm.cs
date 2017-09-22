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
using System.Text.RegularExpressions;

namespace PersonInformation
{
    public partial class MyForm : Form
    {
        // constructor
        public MyForm()
        {
            InitializeComponent();
        }

        // When The Form Is Load 
        private void MyForm_Load(object sender, EventArgs e)
        {
            // make The Icon of Form take the Icon of the Appliction 
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);

            _btTimer.Start();
        }
        
        // Exit Button
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // add Button
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // check if id is valid or not by using reguler Expression.... 
                Regex MyExp = new Regex(@"^\d+$");
                if (!MyExp.IsMatch(tbID.Text))
                {
                    MessageBox.Show("The ID Contains Some Error, Pleace Choose Valid id .", "ID is Error");
                    return;
                }

                // cheack if any one of the fields Empty or not befor begin with add operation
                if (tbID.Text.Trim() == "" || tbName.Text.Trim() == "" || cbContry.SelectedItem.ToString().Trim() == "")
                {
                    MessageBox.Show("Please Enter All Information.", "Error");
                    return;
                }


                else  // if field is not Empty
                {

                    // Create Stream Reader to read the line of INFO file
                    StreamReader MyReader = new StreamReader("INFO.txt");
                    string allLine = MyReader.ReadToEnd();
                    MyReader.Close();

                    // check if the id is used or not befor make add opertion
                    if (allLine.Contains(tbID.Text + ":"))
                    {
                        MessageBox.Show("This 'ID' is used please choose another one ", "Error The Person is Found");
                        tbID.Focus();
                        tbID.SelectAll();
                        return;
                    }

                    // when id is not used make a Stream Writer And Write the info from txtBox in the INFO file
                    StreamWriter MyWriter = new StreamWriter("INFO.txt", true);
                    MyWriter.WriteLine(tbID.Text + ":" + tbName.Text + ":" + cbContry.SelectedItem.ToString());
                    MyWriter.Close();

                    /////////////////////////////////////// Start Save Image ///////////////////////////////// 

                    if (!Directory.Exists("images"))
                    {
                        Directory.CreateDirectory("images");
                    }
                    
                    _personPhoto.Image.Save( "images/" + tbID.Text + ".jpg" );

                    MessageBox.Show("Seccessful Added.", "Added States"); 

                    /////////////////////////////////////// End Save Image /////////////////////////////////// 

                    /////////////////////////////////////// Start Reset Controls /////////////////////////////

                    for (int i = 0; i < this.Controls.Count; i++)  // !!! Note: all item in form called Control ...
                    {
                        if (this.Controls[i] is TextBox || this.Controls[i] is ComboBox)   // is used to check of items 
                        {
                            this.Controls[i].Text = "";
                        }
                    }

                    _personPhoto.Image = new PictureBox().Image;
                    ///// or we can use the foreach to do same thing .

                    //foreach (Control c in this.Controls)
                    //{
                    //    if (c is TextBox || c is TextBox)
                    //    {
                    //        c.Text = "";
                    //    }
                    //}

                    /////////////////////////////////////// End Reset Controls ///////////////////////////////
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Find Button
        private void btFind_Click(object sender, EventArgs e)
        {  
            try
            {
                // Cheak if id fields in
                if (tbID.Text.Trim() != "")
                {
                    string Line;   // متغير لقراءة كل سطر
                    bool Found = false;

                    StreamReader MyReader = new StreamReader("INFO.txt");
                    Line = MyReader.ReadLine();

                    while (Line != null)
                    {   // نبحث اذا كان السطر يحتوي على نفس الرقم للشخص
                        if (Line.Contains(tbID.Text + ":"))
                        {
                            string[] theInfo = Line.Split(':');
                            tbName.Text = theInfo[1];
                            cbContry.Text = theInfo[2];
                     
                            // التأكد من ان الصورة موجودة قبل عرضها 
                            if( File.Exists("images/" + tbID.Text + ".jpg") )
                            {    // عرض الصورة في مربع الصورة حسب الايدي الخاص ب الشخص
                                _personPhoto.Image = Image.FromFile("images/" + tbID.Text + ".jpg");
                            }
                            else
                            {
                                MessageBox.Show("Photo Of The Person Was Not Found." , "Not Found Photo");
                            }
                            Found = true;
                            break;
                        }
                        // اذا جان السطر مايحتوي على رقم الشخص فنقرأ السطر
                        Line = MyReader.ReadLine();
                    }
                    // اغلاق قارئ الملفات ..
                    MyReader.Close();
                    
                    // اذا المتغير مال فاوند بعدة ما تغير وصار ترو يعني هذا الشخص غير موجود فنعرض رسالة للمستخدم
                    if (!Found)
                    {
                        MessageBox.Show("The Person was not found.", "Not Found");

                        // نفرغ التيسكت بوكس للمستخدم
                        tbName.Text = "";
                        cbContry.Text = "";

                        // make empty image into the image in picturBox 
                        _personPhoto.Image = new PictureBox().Image;
                        tbID.Focus();
                        tbID.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Enter ID and try agein.", "Error");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Show All Button
        private void btAll_Click(object sender, EventArgs e)
        {
            try
            {

                TextBox TB = new TextBox();
                Form ShowAll = new Form();

                // make the propertice of the new form like the Main Form
                ShowAll.Icon = this.Icon;
                ShowAll.Width = this.Width;
                ShowAll.Height = this.Height;
                ShowAll.Font = this.Font;
                ShowAll.Text = "All Data";

                // make the new form start in Center of Screen
                ShowAll.StartPosition = FormStartPosition.CenterScreen;

                // make the propertice of the new TextBox
                TB.Multiline = true;                 // Support Multi line 
                TB.Dock = DockStyle.Fill;            // Make the TxtBox Full of The new Form 

                // add txtBox to the new Form
                ShowAll.Controls.Add(TB);
                string allData;

                // new stream reader for read data from file .
                StreamReader MyReader = new StreamReader("INFO.txt");
                TB.Text = allData = MyReader.ReadToEnd();
                MyReader.Close();

                ShowAll.ShowDialog();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Exit From Icon 
        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btChoosePhoto_Click(object sender, EventArgs e)
        { 
            // عمل فلتر لعرض الصور فقط
            _openPhoto.Filter = "Images File|*.jpg;*.png|All Files|*.*";
            _openPhoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // نتأكد من ان المستخدم اختار الصورة وبخلاف ذلك عرض رسالة خطأ
            if(_openPhoto.ShowDialog() == DialogResult.OK)
            {
                // وضع الصورة المختارة من الملف في صندوق الصور
                _personPhoto.Image = Image.FromFile(_openPhoto.FileName);
            }
            else
            {
                MessageBox.Show("Photo Was Not Selected." , "Not Select Photo" );
            }
        }

        
        private void btAllPhoto_Click(object sender, EventArgs e)
        {

            int _topOfBox = 20;  // determinet the new location of text box and picture box 
            Form ShowAll = new Form();
            ShowAll.Icon = this.Icon;
            ShowAll.BackColor = Color.White;
            ShowAll.Width = this.Width;
            ShowAll.Height = this.Height;
            ShowAll.Font = this.Font;
            ShowAll.Text = "All Data With Picture";
            ShowAll.StartPosition = FormStartPosition.CenterScreen;
            ShowAll.AutoScroll = true;
            ShowAll.FormBorderStyle = FormBorderStyle.FixedSingle;
            ShowAll.Show();

            try
            {
                StreamReader MyReader = new StreamReader("INFO.txt");
                string lineOfInfo = MyReader.ReadLine();
                string[] infoString;
                while (!string.IsNullOrEmpty(lineOfInfo))
                {
                    TextBox _txtOfInfo = new TextBox();
                    _txtOfInfo.Location = new Point(120, _topOfBox);
                    _txtOfInfo.Size = new Size(300, 20);
                    _txtOfInfo.Size = this.tbID.Size;

                    PictureBox _personPictur = new PictureBox();
                    _personPictur.Location = new Point(380, _topOfBox);
                    _personPictur.SizeMode = PictureBoxSizeMode.StretchImage;
                    _personPictur.BorderStyle = BorderStyle.FixedSingle;
                    _personPictur.Size = new Size(150, 150);

                    infoString = lineOfInfo.Split(':');
                    _txtOfInfo.Text = lineOfInfo;
                   
                    if (File.Exists("images/" + infoString[0] + ".jpg"))
                    {
                        _personPictur.Image = Image.FromFile("images/" + infoString[0] + ".jpg");
                    }
                    else
                    {
                        _personPictur.Image = new PictureBox().Image ;
                    }

                    ShowAll.Controls.Add(_txtOfInfo);
                    _txtOfInfo.Show();

                    ShowAll.Controls.Add(_personPictur);
                    _personPictur.Show();

                    lineOfInfo = MyReader.ReadLine();
                    _topOfBox += 180;
                }
                MyReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void _btTimer_Tick(object sender, EventArgs e)
        {

            btAdd.Top -= 2;
            btAll.Top -= 2;
            btAllPhoto.Top -= 2;
            btExit.Top -= 2;
            btFind.Top -= 2;
            if (btAdd.Top <= 365)
            {
                _btTimer.Stop();
            }

        }

    }
}
