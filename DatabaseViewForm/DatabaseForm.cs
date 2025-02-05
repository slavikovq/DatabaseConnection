namespace DatabaseViewForm;

public partial class DatabaseForm : Form
{
    private DBDriver _dbDriver;

    public DatabaseForm()
    {
        InitializeComponent();
    }
    

    private void PasswordTextBox_Enter(object sender, EventArgs e)
    {
        PasswordTextBox.Text = "";

        PasswordTextBox.ForeColor = Color.Black;

        PasswordTextBox.UseSystemPasswordChar = true;
    }

    private void PasswordTextBox_Leave(object sender, EventArgs e)
    {
        if (PasswordTextBox.Text.Length == 0)
        {
            PasswordTextBox.ForeColor = Color.Gray;

            PasswordTextBox.Text = "Enter password";

            PasswordTextBox.UseSystemPasswordChar = false;

            SelectNextControl(PasswordTextBox, true, true, false, true);
        }
    }

    private void PopulateListView(List<User> users)
    {
        UserListView.Items.Clear();
        foreach (var user in users)
        {
            ListViewItem item = new ListViewItem();
            item.Text = user.Id.ToString();
            item.SubItems.Add(user.Username);
            item.SubItems.Add(user.CreatedAt.ToString());
            item.SubItems.Add(user.ModifiedAt.ToString());
            UserListView.Items.Add(item);
        }
    }

    private void Login()
    {
        ErrorLabel.Text = "";
        if (_dbDriver is null)
        {
            _dbDriver = new DBDriver(PasswordTextBox.Text);
        }
        PasswordTextBox.Text = "";
    }

    private void LoadUsers()
    {
        List<User> users = _dbDriver.GetUsers();
        if (_dbDriver.ThrownException is not null)
        {
            ErrorLabel.Text = _dbDriver.ThrownException.Message;
            _dbDriver.ThrownException = null;
            _dbDriver = null;
        }
        else
        {
            PopulateListView(users);
        }
    }

    private void HideButtons()
    {
        AddUser.Visible = true;
        AddUserTB.Visible = true;
        RemoveUser.Visible = true;
        RemoveUserTB.Visible = true;
        FetchButton.Visible = false;
        PasswordTextBox.Visible = false;
    }
    
    private void FetchButton_Click(object sender, EventArgs e)
    {
        Login();
        LoadUsers();
        HideButtons();
        
    }

    private void PasswordTextBox_KeyPressed(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (int)Keys.Enter)
        {
            Login();
            LoadUsers();
            HideButtons();
        }
        
    }

    private void AddUser_Click(object sender, EventArgs e)
    {
        if (AddUserTB.Text == null)
        {
            
        }
        _dbDriver.InsertUser(AddUserTB.Text.ToString());
        LoadUsers();
        AddUserTB.Text = "";
    }

    private void RemoveUserFunction(string input)
    {
        
        string[] ids = input.Split(',').ToArray();

        if (!ids.All(id => int.TryParse(id, out _)))
        {
            return;
        }
        foreach (string id in ids)
        {
            _dbDriver.RemoveUser(id);    
        }
    }
    
    private void RemoveUser_Click(object sender, EventArgs e)
    {
        RemoveUserFunction(RemoveUserTB.Text);
        LoadUsers();
        RemoveUserTB.Text = "";
    }

    private void AddUserTB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (int)Keys.Enter)
        { 
            _dbDriver.InsertUser(AddUserTB.Text.ToString());
            LoadUsers();
            AddUserTB.Text = "";
        }
    }


    private void RemoveUserTB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (int)Keys.Enter)
        { 
            RemoveUserFunction(RemoveUserTB.Text);
            LoadUsers();
            RemoveUserTB.Text = "";
        }
    }

    private void SearchBox_KeyUp(object sender, KeyEventArgs e)
    {
        List<User> users = _dbDriver.GetSpecificUser(SearchBox.Text);
        if (_dbDriver.ThrownException is not null)
        {
            ErrorLabel.Text = _dbDriver.ThrownException.Message;
            _dbDriver.ThrownException = null;
            _dbDriver = null;
        }
        else
        {
            PopulateListView(users);
        }
    }
}