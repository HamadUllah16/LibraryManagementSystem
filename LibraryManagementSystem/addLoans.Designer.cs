namespace LibraryManagementSystem
{
    partial class addLoans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bookIdLabel;
            System.Windows.Forms.Label memberIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addLoans));
            System.Windows.Forms.Label returnDateLabel;
            System.Windows.Forms.Label loanDateLabel;
            this.loanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookIdTextBox = new System.Windows.Forms.TextBox();
            this.memberIdTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.returnDateTextBox = new System.Windows.Forms.TextBox();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new LibraryManagementSystem.Database1DataSet1();
            this.loanTableAdapter = new LibraryManagementSystem.Database1DataSet1TableAdapters.LoanTableAdapter();
            this.tableAdapterManager = new LibraryManagementSystem.Database1DataSet1TableAdapters.TableAdapterManager();
            this.loanDateTextBox1 = new System.Windows.Forms.TextBox();
            bookIdLabel = new System.Windows.Forms.Label();
            memberIdLabel = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            loanDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingNavigator)).BeginInit();
            this.loanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new System.Drawing.Point(239, 180);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new System.Drawing.Size(55, 16);
            bookIdLabel.TabIndex = 3;
            bookIdLabel.Text = "book Id:";
            // 
            // memberIdLabel
            // 
            memberIdLabel.AutoSize = true;
            memberIdLabel.Location = new System.Drawing.Point(239, 208);
            memberIdLabel.Name = "memberIdLabel";
            memberIdLabel.Size = new System.Drawing.Size(74, 16);
            memberIdLabel.TabIndex = 5;
            memberIdLabel.Text = "member Id:";
            // 
            // loanBindingNavigator
            // 
            this.loanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loanBindingNavigator.BindingSource = this.loanBindingSource;
            this.loanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loanBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.loanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.loanBindingNavigatorSaveItem});
            this.loanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loanBindingNavigator.Name = "loanBindingNavigator";
            this.loanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loanBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.loanBindingNavigator.TabIndex = 0;
            this.loanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // loanBindingNavigatorSaveItem
            // 
            this.loanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loanBindingNavigatorSaveItem.Image")));
            this.loanBindingNavigatorSaveItem.Name = "loanBindingNavigatorSaveItem";
            this.loanBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.loanBindingNavigatorSaveItem.Text = "Save Data";
            this.loanBindingNavigatorSaveItem.Click += new System.EventHandler(this.loanBindingNavigatorSaveItem_Click);
            // 
            // bookIdTextBox
            // 
            this.bookIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "bookId", true));
            this.bookIdTextBox.Location = new System.Drawing.Point(320, 177);
            this.bookIdTextBox.Name = "bookIdTextBox";
            this.bookIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.bookIdTextBox.TabIndex = 4;
            // 
            // memberIdTextBox
            // 
            this.memberIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "memberId", true));
            this.memberIdTextBox.Location = new System.Drawing.Point(320, 205);
            this.memberIdTextBox.Name = "memberIdTextBox";
            this.memberIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.memberIdTextBox.TabIndex = 6;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(71, 103);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(92, 32);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(657, 373);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 32);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loans";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new System.Drawing.Point(238, 268);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new System.Drawing.Size(75, 16);
            returnDateLabel.TabIndex = 16;
            returnDateLabel.Text = "return Date:";
            // 
            // returnDateTextBox
            // 
            this.returnDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "returnDate", true));
            this.returnDateTextBox.Location = new System.Drawing.Point(319, 265);
            this.returnDateTextBox.Name = "returnDateTextBox";
            this.returnDateTextBox.Size = new System.Drawing.Size(201, 22);
            this.returnDateTextBox.TabIndex = 17;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.LoanTableAdapter = this.loanTableAdapter;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryManagementSystem.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loanDateLabel
            // 
            loanDateLabel.AutoSize = true;
            loanDateLabel.Location = new System.Drawing.Point(239, 243);
            loanDateLabel.Name = "loanDateLabel";
            loanDateLabel.Size = new System.Drawing.Size(68, 16);
            loanDateLabel.TabIndex = 17;
            loanDateLabel.Text = "loan Date:";
            // 
            // loanDateTextBox1
            // 
            this.loanDateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loanBindingSource, "loanDate", true));
            this.loanDateTextBox1.Location = new System.Drawing.Point(319, 237);
            this.loanDateTextBox1.Name = "loanDateTextBox1";
            this.loanDateTextBox1.Size = new System.Drawing.Size(201, 22);
            this.loanDateTextBox1.TabIndex = 18;
            // 
            // addLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(loanDateLabel);
            this.Controls.Add(this.loanDateTextBox1);
            this.Controls.Add(returnDateLabel);
            this.Controls.Add(this.returnDateTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(bookIdLabel);
            this.Controls.Add(this.bookIdTextBox);
            this.Controls.Add(memberIdLabel);
            this.Controls.Add(this.memberIdTextBox);
            this.Controls.Add(this.loanBindingNavigator);
            this.Name = "addLoans";
            this.Text = "addLoans";
            this.Load += new System.EventHandler(this.addLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingNavigator)).EndInit();
            this.loanBindingNavigator.ResumeLayout(false);
            this.loanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private Database1DataSet1TableAdapters.LoanTableAdapter loanTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton loanBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bookIdTextBox;
        private System.Windows.Forms.TextBox memberIdTextBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox returnDateTextBox;
        private System.Windows.Forms.TextBox loanDateTextBox1;
    }
}