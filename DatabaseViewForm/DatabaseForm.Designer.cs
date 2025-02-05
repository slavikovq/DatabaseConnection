namespace DatabaseViewForm;

partial class DatabaseForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        UserListView = new System.Windows.Forms.ListView();
        idCol = new System.Windows.Forms.ColumnHeader();
        usernameCol = new System.Windows.Forms.ColumnHeader();
        createdDateCol = new System.Windows.Forms.ColumnHeader();
        modifiedDateCol = new System.Windows.Forms.ColumnHeader();
        PasswordTextBox = new System.Windows.Forms.TextBox();
        FetchButton = new System.Windows.Forms.Button();
        ErrorLabel = new System.Windows.Forms.Label();
        AddUser = new System.Windows.Forms.Button();
        AddUserTB = new System.Windows.Forms.TextBox();
        RemoveUser = new System.Windows.Forms.Button();
        RemoveUserTB = new System.Windows.Forms.TextBox();
        SearchBox = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // UserListView
        // 
        UserListView.BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idCol, usernameCol, createdDateCol, modifiedDateCol });
        UserListView.Location = new System.Drawing.Point(69, 71);
        UserListView.Name = "UserListView";
        UserListView.Size = new System.Drawing.Size(719, 169);
        UserListView.TabIndex = 0;
        UserListView.UseCompatibleStateImageBehavior = false;
        UserListView.View = System.Windows.Forms.View.Details;
        // 
        // idCol
        // 
        idCol.Name = "idCol";
        idCol.Text = "Id";
        idCol.Width = 43;
        // 
        // usernameCol
        // 
        usernameCol.Name = "usernameCol";
        usernameCol.Text = "Username";
        usernameCol.Width = 276;
        // 
        // createdDateCol
        // 
        createdDateCol.Name = "createdDateCol";
        createdDateCol.Text = "Created";
        createdDateCol.Width = 226;
        // 
        // modifiedDateCol
        // 
        modifiedDateCol.Name = "modifiedDateCol";
        modifiedDateCol.Text = "Modified";
        modifiedDateCol.Width = 413;
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)255)));
        PasswordTextBox.Location = new System.Drawing.Point(68, 246);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new System.Drawing.Size(287, 23);
        PasswordTextBox.TabIndex = 1;
        PasswordTextBox.Enter += PasswordTextBox_Enter;
        PasswordTextBox.KeyPress += PasswordTextBox_KeyPressed;
        PasswordTextBox.Leave += PasswordTextBox_Leave;
        // 
        // FetchButton
        // 
        FetchButton.Location = new System.Drawing.Point(68, 275);
        FetchButton.Name = "FetchButton";
        FetchButton.Size = new System.Drawing.Size(123, 26);
        FetchButton.TabIndex = 2;
        FetchButton.Text = "Fetch";
        FetchButton.UseVisualStyleBackColor = true;
        FetchButton.Click += FetchButton_Click;
        // 
        // ErrorLabel
        // 
        ErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        ErrorLabel.ForeColor = System.Drawing.Color.Red;
        ErrorLabel.Location = new System.Drawing.Point(306, 312);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new System.Drawing.Size(426, 24);
        ErrorLabel.TabIndex = 3;
        // 
        // AddUser
        // 
        AddUser.Location = new System.Drawing.Point(68, 246);
        AddUser.Name = "AddUser";
        AddUser.Size = new System.Drawing.Size(108, 23);
        AddUser.TabIndex = 5;
        AddUser.Text = "Add new user";
        AddUser.UseVisualStyleBackColor = true;
        AddUser.Visible = false;
        AddUser.Click += AddUser_Click;
        // 
        // AddUserTB
        // 
        AddUserTB.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)255)));
        AddUserTB.Location = new System.Drawing.Point(69, 278);
        AddUserTB.Name = "AddUserTB";
        AddUserTB.Size = new System.Drawing.Size(286, 23);
        AddUserTB.TabIndex = 6;
        AddUserTB.Visible = false;
        AddUserTB.KeyPress += AddUserTB_KeyPress;
        // 
        // RemoveUser
        // 
        RemoveUser.Location = new System.Drawing.Point(69, 313);
        RemoveUser.Name = "RemoveUser";
        RemoveUser.Size = new System.Drawing.Size(116, 23);
        RemoveUser.TabIndex = 7;
        RemoveUser.Text = "Remove user by ID";
        RemoveUser.UseVisualStyleBackColor = true;
        RemoveUser.Visible = false;
        RemoveUser.Click += RemoveUser_Click;
        // 
        // RemoveUserTB
        // 
        RemoveUserTB.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)255)));
        RemoveUserTB.Location = new System.Drawing.Point(69, 342);
        RemoveUserTB.Name = "RemoveUserTB";
        RemoveUserTB.Size = new System.Drawing.Size(286, 23);
        RemoveUserTB.TabIndex = 8;
        RemoveUserTB.Visible = false;
        RemoveUserTB.KeyPress += RemoveUserTB_KeyPress;
        // 
        // SearchBox
        // 
        SearchBox.Location = new System.Drawing.Point(69, 42);
        SearchBox.Name = "SearchBox";
        SearchBox.PlaceholderText = "Search";
        SearchBox.Size = new System.Drawing.Size(524, 23);
        SearchBox.TabIndex = 9;
        SearchBox.KeyUp += SearchBox_KeyUp;
        // 
        // DatabaseForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(SearchBox);
        Controls.Add(RemoveUserTB);
        Controls.Add(RemoveUser);
        Controls.Add(AddUserTB);
        Controls.Add(AddUser);
        Controls.Add(ErrorLabel);
        Controls.Add(FetchButton);
        Controls.Add(PasswordTextBox);
        Controls.Add(UserListView);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox SearchBox;

    private System.Windows.Forms.Button RemoveUser;
    private System.Windows.Forms.TextBox RemoveUserTB;

    private System.Windows.Forms.Button AddUser;
    private System.Windows.Forms.TextBox AddUserTB;

    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.Button FetchButton;

    private System.Windows.Forms.TextBox PasswordTextBox;

    private System.Windows.Forms.ColumnHeader idCol;
    private System.Windows.Forms.ColumnHeader usernameCol;
    private System.Windows.Forms.ColumnHeader createdDateCol;
    private System.Windows.Forms.ColumnHeader modifiedDateCol;

    private System.Windows.Forms.ListView UserListView;

    #endregion
}