using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace AlkoParty
{
    public partial class Start_Window : Form
    {
        public string USID;
        public string ISA;
        public string ALA;
        public string EOA;
        public string MA;
        public string PRA;
        public Start_Window()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------
        //Объекты для аутентификации пользователей
        public ComboBox Login_Text = new ComboBox();
        public Label Login_Label = new Label();
        public TextBox Pass_Text = new TextBox();
        public Label Pass_Label = new Label();
        public Button Button_Enter = new Button();
        public Button Button_Register = new Button();
        //-----------------------------------------------------
        //Объекты для подключения к источнику данных
        public ComboBox Server_CB = new ComboBox();
        public ComboBox DataBase_CB = new ComboBox();
        public Label Base_Login_Label = new Label();
        public TextBox Base_Login_Text = new TextBox();
        public Label Base_Password_Label = new Label();
        public TextBox Base_Password_Text = new TextBox();
        public Button Check_Connection_Button = new Button();
        public Button Connect_Data_Source_Button = new Button();
        //-----------------------------------------------------
        //Объекты формы регистрации
        public Form Registration_Window = new Form();
        public Label New_Login_Label = new Label();
        public Label New_Password_Label = new Label();
        public Label Conform_Password_Label = new Label();
        public Label Count_Login_Char_Label = new Label();
        public Label Count_Password_Char_Label = new Label();
        public TextBox New_Login_Text = new TextBox();
        public TextBox New_Password_Text = new TextBox();
        public TextBox Conform_Password_Text = new TextBox();
        public Button Registrate_Button = new Button();
        public Button Cancel_Button = new Button();
        public int Log_Count = 16; 
        public int Pass_Count = 16;

        private void Button3_Click(object sender, EventArgs e)
        {
            
            switch (MessageBox.Show("Завершить работу прилоджения?", Application.ProductName + " " + Application.ProductVersion, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                   
                    break;
            }
        }

      

   
        private void Pass_Text_Leave(object sender, EventArgs e)
        {
            if (Pass_Text.TextLength == 0)
            {
                Pass_Text.BackColor = Color.Red;
            }
            else
            {
                Pass_Text.BackColor = Color.White;
            }
        }

        private void Base_Login_Text_Leave(object sender, EventArgs e)
        {
            if (Base_Login_Text.TextLength == 0
                || Base_Login_Text.Text == "Введите логин от источника данных")
            {
                Base_Login_Text.BackColor = Color.Red;
                Check_Connection_Button.Enabled = false;
            }
            else
            {
                Base_Login_Text.BackColor = Color.White;
                Check_Connection_Button.Enabled = true;
            }
        }

        private void Base_Password_Text_Leave(object sender, EventArgs e)
        {
            if (Base_Password_Text.TextLength == 0 || Base_Password_Text.Text == "Введите пароль от источника данных")
            {
                Base_Password_Text.BackColor = Color.Red;
                Check_Connection_Button.Enabled = false;
            }
            else
            {
                Base_Password_Text.BackColor = Color.White;
                Check_Connection_Button.Enabled = true;
            }
        }

        private void Base_Password_Text_Enter(object sender, EventArgs e)
        {
            switch (Base_Password_Text.Text)
            {
                case ("Введите пароль от источника данных"):
                    Base_Password_Text.Clear();
                    Base_Password_Text.PasswordChar = '*';
                    break;
                case (""):
                    Base_Password_Text.Text = "Введите пароль от источника данных";
                    Base_Password_Text.PasswordChar = '\0';
                    break;
            }
        }

        private void Base_Login_Text_Enter(object sender, EventArgs e)
        {
            switch (Base_Login_Text.Text)
            {
                case ("Введите логин от источника данных"):
                    Base_Login_Text.Clear();
                    Base_Login_Text.PasswordChar = '*';
                    break;
                case (""):
                    Base_Login_Text.Text = "Введите логин от источника данных";
                    Base_Login_Text.PasswordChar = '\0';
                    break;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            switch (button1.Text)
            {
                case "ВХОД":
                    button1.Text = "ЗАКРЫТЬ АВТОРИЗАЦИЮ";
                    this.Width = this.Width + 250;
                    //-----------------------------------------------------
                    // Создание надписи "Введите логин"
                    Login_Label.Top = 2; 
                    Login_Label.Left = this.Width - 230;
                    Login_Label.Height = 13;
                    Login_Label.Text = "Введите логин:";
                    this.Controls.Add(Login_Label);
                    //-----------------------------------------------------
                    // Создание поля ввода логина
                    
                    Login_Text.Items.AddRange(new string[] { "Admin", "Sklad", "Kadr", "Bugalter" });
                    Login_Text.Items[0] = "Admin";
                    Login_Text.Items[1] = "Sklad";
                    Login_Text.Items[2] = "Kadr";
                    Login_Text.Items[3] = "Bugalter";
                    Login_Text.Left = this.Width - 230;
                    Login_Text.Top = Login_Label.Height + 2;
                    Login_Text.Width = 200;
                  
                    this.Controls.Add(Login_Text);
                    //-----------------------------------------------------
                    // Создание надписи "Введите пароль"
                    Pass_Label.Left = this.Width - 230; 
                    Pass_Label.Height = 13;
                    Pass_Label.Top = Login_Text.Top + Login_Text.Height + 2;
                    Pass_Label.Text = "Введите пароль:";
                    this.Controls.Add(Pass_Label);
                    //-----------------------------------------------------
                    //Создание поля ввода пароля
                    Pass_Text.Left = this.Width - 230;
                    Pass_Text.Top = Pass_Label.Top + Pass_Label.Height + 2;
                    Pass_Text.Width = 200;
                    Pass_Text.PasswordChar = '*';
                    Pass_Text.Clear();
                    Pass_Text.BackColor = Color.White;
                    Pass_Text.Leave += this.Pass_Text_Leave;
                    this.Controls.Add(Pass_Text);
                    //-----------------------------------------------------
                    //Создание кнопки "Авторизоваться"
                    Button_Enter.Top = Pass_Text.Top + Pass_Text.Height + 4;
                    Button_Enter.Left = this.Width - 230;
                    Button_Enter.Text = "Авторизоваться";
                    Button_Enter.Width = 99;
                    
                    Button_Enter.FlatStyle = FlatStyle.Flat;
                    Button_Enter.FlatAppearance.BorderSize = 0;
                    Button_Enter.Font = new Font("Arial Black", 7, FontStyle.Bold);
                    Button_Enter.Click += this.Button_Enter_Click;
                   
                    this.Controls.Add(Button_Enter);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (button2.Text)
            {
                case "НАСТРОЙКА ПОДКЛЮЧЕНИЯ":
                    button2.Text = "ЗАКРЫТЬ НАСТРОЙКУ";
                    //-----------------------------------------------------
                    //Создание выпадающего списка всех серверов
                    Server_CB.Top = this.Height + 2;
                    Server_CB.Left = 5;
                    Server_CB.Width = this.Width - 10;
                    Server_CB.Items.Clear();
                    Server_CB.Text = "Выберите доступные сервера";
                    System.Data.Sql.SqlDataSourceEnumerator Server_List = 
                        System.Data.Sql.SqlDataSourceEnumerator.Instance;
                    System.Data.DataTable Server_Table = Server_List.GetDataSources();
                    foreach (DataRow row in Server_Table.Rows)
                         {
                            Server_CB.Items.Add(row[0]+"\\"+row[1]);
                         }
                    this.Controls.Add(Server_CB);
                    //-----------------------------------------------------
                    //Создвание надписи "Логин от источника данных"
                    Base_Login_Label.Top = Server_CB.Top + Server_CB.Height + 5;
                    Base_Login_Label.Left = 5;
                    Base_Login_Label.Height = 13;
                    Base_Login_Label.Width = this.Width - 10;
                    Base_Login_Label.Text = "Логин от источника данных:";
                    this.Controls.Add(Base_Login_Label);
                    //-----------------------------------------------------
                    //Создание поля ввода логина от базы данных
                    Base_Login_Text.Top = Base_Login_Label.Top + Base_Login_Label.Height + 5;
                    Base_Login_Text.Left = 5;
                    Base_Login_Text.Width = this.Width - 10;
                    Base_Login_Text.Clear();
                    Base_Login_Text.Text = "Введите логин от источника данных";
                    Base_Login_Text.BackColor = Color.White;
                    Base_Login_Text.Leave += Base_Login_Text_Leave;
                    Base_Login_Text.Enter += Base_Login_Text_Enter;
                    this.Controls.Add(Base_Login_Text);
                    //-----------------------------------------------------
                    //Создвание надписи "Пароль от источника данных"
                    Base_Password_Label.Top = Base_Login_Text.Top + Base_Login_Text.Height + 5;
                    Base_Password_Label.Left = 5;
                    Base_Password_Label.Height = 13;
                    Base_Password_Label.Width = this.Width - 10;
                    Base_Password_Label.Text = "Пароль от источника данных:";
                    this.Controls.Add(Base_Password_Label);
                    //-----------------------------------------------------
                    //Создание поля ввода пароль от базы данных
                    Base_Password_Text.Top = Base_Password_Label.Top + Base_Password_Label.Height + 5;
                    Base_Password_Text.Left = 5;
                    Base_Password_Text.Width = this.Width - 10;
                    Base_Password_Text.Clear();
                    Base_Password_Text.Text = "Введите пароль от источника данных";
                    Base_Password_Text.BackColor = Color.White;
                    Base_Password_Text.Leave += Base_Password_Text_Leave;
                    Base_Password_Text.Enter += Base_Password_Text_Enter;
                    this.Controls.Add(Base_Password_Text);
                    //-----------------------------------------------------
                    //Создание выпадающего списка всех баз данных
                    DataBase_CB.Top = Base_Password_Text.Top + Base_Password_Text.Height + 5;
                    DataBase_CB.Left = 5;
                    DataBase_CB.Width = this.Width - 10;
                    DataBase_CB.DataSource = null;
                    DataBase_CB.DisplayMember = "";
                    DataBase_CB.Items.Clear();
                    DataBase_CB.Text = "Выберите нужную Базу данных";
                    DataBase_CB.Click += DataBase_CB_Click;
                    this.Controls.Add(DataBase_CB);
                    //-----------------------------------------------------
                    //Создание кнопки "Проверка подключения"
                    Check_Connection_Button.Top = DataBase_CB.Top + DataBase_CB.Height + 5;
                    Check_Connection_Button.Left = 5;
                    Check_Connection_Button.Height = 30;
                    Check_Connection_Button.Width = 200;
                    Check_Connection_Button.Text = "Проверка подключения";
                    Check_Connection_Button.BackColor = Color.YellowGreen;
                    Check_Connection_Button.ForeColor = Color.Black;
                    Check_Connection_Button.FlatStyle = FlatStyle.Flat;
                    Check_Connection_Button.Enabled = false;
                    Check_Connection_Button.FlatAppearance.BorderSize = 0;
                    Check_Connection_Button.Font = new Font("Arial Black", 8, FontStyle.Bold);
                    Check_Connection_Button.Click += this.Check_Connection_Button_Click;
                   
                    this.Controls.Add(Check_Connection_Button);
                    //-----------------------------------------------------
                    // Создание кнопки "Подключиться"
                    Connect_Data_Source_Button.Top = DataBase_CB.Top + DataBase_CB.Height + 5;
                    Connect_Data_Source_Button.Left = Check_Connection_Button.Left + Check_Connection_Button.Width + 5;
                    Connect_Data_Source_Button.Height = 30;
                    Connect_Data_Source_Button.Width = 200;
                    Connect_Data_Source_Button.Text = "Подключиться";
                    Connect_Data_Source_Button.Enabled = false;
                    //Connect_Data_Source_Button.BackColor = Color.YellowGreen;
                   // Connect_Data_Source_Button.ForeColor = Color.Black;
                    Connect_Data_Source_Button.FlatStyle = FlatStyle.Flat;
                    Connect_Data_Source_Button.FlatAppearance.BorderSize = 0;
                    Connect_Data_Source_Button.Font = new Font("Arial Black", 8, FontStyle.Bold);
                    Connect_Data_Source_Button.Click += this.Connect_Data_Source_Button_Click;
                   
                    this.Controls.Add(Connect_Data_Source_Button);
                    this.Height = this.Height + 200;
                    break;
                case "ЗАКРЫТЬ НАСТРОЙКУ":
                    this.Controls.Remove(Server_CB);
                    this.Controls.Remove(Base_Login_Label);
                    this.Controls.Remove(Base_Login_Text);
                    this.Controls.Remove(Base_Password_Label);
                    this.Controls.Remove(Base_Password_Text);
                    this.Controls.Remove(DataBase_CB);
                    this.Controls.Remove(Check_Connection_Button);
                    this.Controls.Remove(Connect_Data_Source_Button);
                    button2.Text = "НАСТРОЙКА ПОДКЛЮЧЕНИЯ";
                    this.Height = this.Height - 200;
                    break;
            }
        }

        public void DataBase_CB_Click (object sender, EventArgs e)
        {
            try
            {
                SqlConnection Try_Connect = new SqlConnection();
                Try_Connect.ConnectionString = "Data Source=" + Server_CB.Text
                    + "; Initial Catalog= ; Persist Security Info=True;User ID=" 
                    + Base_Login_Text.Text + ";Password=\"" + Base_Password_Text.Text + "\"";
                Try_Connect.Open();
                SqlDataAdapter Base_Adapter = new SqlDataAdapter("exec sp_helpdb", Try_Connect);
                DataSet Base_Data_Set = new DataSet();
                Base_Adapter.Fill(Base_Data_Set, "db");
                DataBase_CB.DataSource = Base_Data_Set.Tables[0];
                DataBase_CB.DisplayMember = "name";
                Check_Connection_Button.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Check_Connection_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Try_Connect = new SqlConnection();
                Try_Connect.ConnectionString = "Data Source="+ Server_CB.Text+"; Initial Catalog="+DataBase_CB.Text
                    +"; Persist Security Info=True;User ID="+Base_Login_Text.Text+";Password=\""+ Base_Password_Text.Text+"\"";
                Try_Connect.Open();
                MessageBox.Show("Подлючение к \""+DataBase_CB.Text+"\" есть, нажмите кнопку \"Подключиться\"");
                Connect_Data_Source_Button.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Connect_Data_Source_Button_Click(object sender, EventArgs e)
        {
            
            this.Controls.Remove(Server_CB);
            this.Controls.Remove(Base_Login_Label);
            this.Controls.Remove(Base_Login_Text);
            this.Controls.Remove(Base_Password_Label);
            this.Controls.Remove(Base_Password_Text);
            this.Controls.Remove(DataBase_CB);
            this.Controls.Remove(Check_Connection_Button);
            this.Controls.Remove(Connect_Data_Source_Button);
            button1.Enabled = true;
            button2.Enabled = false;
            button2.Text = "НАСТРОЙКА ПОДКЛЮЧЕНИЯ";
            this.Height = this.Height - 200;
            label1.Text = Application.ProductVersion.ToString() + " - Подключение к источнику данных есть.";
        }


        public void Button_Enter_Click(object sender, EventArgs e)
        {
            

            if (Login_Text.Text == "Admin" && Pass_Text.Text == "admin")
            {
                MessageBox.Show("Вы вошли как администратор");
                this.Close();
                void NewForm()
                {
                    AlkoListWindow form = new AlkoListWindow();
                    form.ShowDialog();
                }
                new System.Threading.Thread(NewForm).Start();

            }

            if (Login_Text.Text == "Kadr" && Pass_Text.Text == "kadr")
            {
                MessageBox.Show("Вы вошли как кадровый сотрудник");
                this.Close();
                void NewForm()
                {
                    Kadr form = new Kadr();
                    form.ShowDialog();
                }
                new System.Threading.Thread(NewForm).Start();
            }

            if (Login_Text.Text == "Sklad" && Pass_Text.Text == "sklad")
            {
                MessageBox.Show("Вы вошли как складской рабочий");
                this.Close();
                void NewForm()
                {
                    Sklad form = new Sklad();
                    form.ShowDialog();
                }
                new System.Threading.Thread(NewForm).Start();
            }

            if (Login_Text.Text == "Bugalter" && Pass_Text.Text == "bugalter")
            {
                MessageBox.Show("Вы вошли как бугалтер");
                this.Close();
                void NewForm()
                {
                    Bug form = new Bug();
                    form.ShowDialog();
                }
                new System.Threading.Thread(NewForm).Start();
            }
        }

        private void New_Password_Text_Enter(object sender, EventArgs e)
        {
            New_Password_Text.BackColor = Color.White;
            Conform_Password_Text.BackColor = Color.White;
        }

        private void Conform_Password_Text_Enter (object sender, EventArgs e)
        {
            New_Password_Text.BackColor = Color.White;
            Conform_Password_Text.BackColor = Color.White;
        }
    }
}
