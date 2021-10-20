using System;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class FormTapharo : Form
    {
        private User_Logic _user_logic = new User_Logic();
        private UserRole userRole;
        private string oldUserName;
        public FormTapharo()
        {
            InitializeComponent();
            ListviewUser.MultiSelect = true;
        }
        
        private void BTNInsertUser_Click(object sender, EventArgs e)
        {
            
            string Firstname = TXTBFirstname.Text;
            string Lastname = TXTBLastname.Text;
            string Username = TXTBUsername.Text;
            string Password = TXTBPassword.Text;
            string Email = TXTBEmail.Text;
            Email = Email + "@hotmail.com";
            if (RB_Admin.Checked)
            {
                userRole = UserRole.Admin;
            }
            else
            {
                userRole = UserRole.User;
            }
            if (_user_logic.UserCheck(Username))
            {
                MessageBox.Show("Username is already taken");
            }
            
            
            _user_logic.InsertUser(Username, Password, Firstname, Lastname, userRole, Email);

            refreshList();
        }

        
        private void FullListviewUser()
        {
            ListviewUser.Columns.Add("Username", 100);
            ListviewUser.Columns.Add("Password", 100);
            ListviewUser.Columns.Add("Firstname", 100);
            ListviewUser.Columns.Add("Lastname", 100);
            ListviewUser.Columns.Add("User Role", 100);
            ListviewUser.Columns.Add("Email", 100);
            foreach (User user in _user_logic.GetnewUser())
            {
                ListViewItem listview = new ListViewItem(user.Username);
                listview.SubItems.Add(user.Password);
                listview.SubItems.Add(user.Firstname);
                listview.SubItems.Add(user.Lastname);
                listview.SubItems.Add(user.UserRole.ToString());
                listview.SubItems.Add(user.Email);
                ListviewUser.Items.AddRange(new ListViewItem[] { listview });
            }
        }

        private void refreshList()
        {
            ListviewUser.Clear();
            FullListviewUser();
            ListviewUser.SelectedItems.Clear();
            this.EmptyTextbBox();
        }
        
        private void FormTapharo_Load(object sender, EventArgs e)
        {
            refreshList();
        }
       
        private void ListviewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListviewUser.SelectedItems.Count == 0)
                return;

            EmptyTextbBox();
            string username, password, firstname, lastname, email;

            this.oldUserName = this.ListviewUser.SelectedItems[0].SubItems[0].Text;
            username = this.ListviewUser.SelectedItems[0].SubItems[0].Text;
            password = this.ListviewUser.SelectedItems[0].SubItems[1].Text;
            firstname = this.ListviewUser.SelectedItems[0].SubItems[2].Text;
            lastname = this.ListviewUser.SelectedItems[0].SubItems[3].Text;
            this.userRole = (UserRole)Enum.Parse(typeof(UserRole), this.ListviewUser.SelectedItems[0].SubItems[4].Text);
            email = this.ListviewUser.SelectedItems[0].SubItems[5].Text;
            
            TXTBUsername.Text = username;
            TXTBPassword.Text = password;
            TXTBFirstname.Text = firstname;
            TXTBLastname.Text = lastname;
            if (this.userRole == UserRole.Admin )
            {
                RB_Admin.Checked = true;
            }
            else
            {
                RB_User.Checked = true;
            }
            TXTBEmail.Text = email;

           
        }
        private void EmptyTextbBox()
        {
            TXTBUsername.Text = string.Empty;
            TXTBPassword.Text = string.Empty;
            TXTBFirstname.Text = string.Empty;
            TXTBLastname.Text = string.Empty;
            TXTBEmail.Text = string.Empty;
        }
       
        private void BTNDeleteAccess_Click(object sender, EventArgs e)
        {
            if(this.oldUserName == null) 
            {
                return;
            }
            _user_logic.DeleteUser(this.oldUserName);
            this.oldUserName = null;
            refreshList();
        }
        private void BTNUpdateAccess_Click(object sender, EventArgs e)
        {
            string username = TXTBUsername.Text;
            string password = TXTBPassword.Text;
            string firstname = TXTBFirstname.Text;
            string lastname = TXTBLastname.Text;
            string email = TXTBEmail.Text;


            _user_logic.UpdateUser(this.oldUserName, firstname, lastname, username, password, this.userRole, email);
            this.oldUserName = username;
            refreshList();
        }
    }
}
