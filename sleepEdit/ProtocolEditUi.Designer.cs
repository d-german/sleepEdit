namespace ProtocolUi
{
    partial class ProtocolEditUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtocolEditUi));
            this.mProtocolTreeView = new System.Windows.Forms.TreeView();
            this.mContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLinkIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mImageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.neToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mUndoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mRedoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.mAddSectionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mAddChildToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mIdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mIdLabelValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mLinkLabelText = new System.Windows.Forms.Label();
            this.mLinkTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mQuestionListComboBox = new System.Windows.Forms.ComboBox();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.AddSubTextItemButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mDocument = new System.Windows.Forms.RichTextBox();
            this.mContextMenuStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mProtocolTreeView
            // 
            this.mProtocolTreeView.AllowDrop = true;
            this.mProtocolTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mProtocolTreeView.ContextMenuStrip = this.mContextMenuStrip;
            this.mProtocolTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mProtocolTreeView.ImageIndex = 30;
            this.mProtocolTreeView.ImageList = this.mImageList;
            this.mProtocolTreeView.Location = new System.Drawing.Point(-2, 29);
            this.mProtocolTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.mProtocolTreeView.Name = "mProtocolTreeView";
            this.mProtocolTreeView.SelectedImageIndex = 30;
            this.mProtocolTreeView.Size = new System.Drawing.Size(403, 757);
            this.mProtocolTreeView.TabIndex = 0;
            this.mProtocolTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            this.mProtocolTreeView.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.mProtocolTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mProtocolTreeView_AfterSelect);
            this.mProtocolTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tree_DragEnter);
            this.mProtocolTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Tree_ItemDrag);
            this.mProtocolTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mProtocolTreeView_MouseDown);
            // 
            // mContextMenuStrip
            // 
            this.mContextMenuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChildToolStripMenuItem,
            this.removeChildToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.undoMoveToolStripMenuItem,
            this.redoMoveToolStripMenuItem,
            this.setLinkIdToolStripMenuItem});
            this.mContextMenuStrip.Name = "mContextMenuStrip";
            this.mContextMenuStrip.Size = new System.Drawing.Size(194, 148);
            // 
            // addChildToolStripMenuItem
            // 
            this.addChildToolStripMenuItem.Name = "addChildToolStripMenuItem";
            this.addChildToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.addChildToolStripMenuItem.Text = "Add Child";
            this.addChildToolStripMenuItem.Click += new System.EventHandler(this.addChildToolStripMenuItem_Click);
            // 
            // removeChildToolStripMenuItem
            // 
            this.removeChildToolStripMenuItem.Name = "removeChildToolStripMenuItem";
            this.removeChildToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.removeChildToolStripMenuItem.Text = "Remove Node";
            this.removeChildToolStripMenuItem.Click += new System.EventHandler(this.removeChildToolStripMenuItem_Click);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // undoMoveToolStripMenuItem
            // 
            this.undoMoveToolStripMenuItem.Name = "undoMoveToolStripMenuItem";
            this.undoMoveToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.undoMoveToolStripMenuItem.Text = "Undo Move";
            this.undoMoveToolStripMenuItem.Click += new System.EventHandler(this.undoMoveToolStripMenuItem_Click);
            // 
            // redoMoveToolStripMenuItem
            // 
            this.redoMoveToolStripMenuItem.Name = "redoMoveToolStripMenuItem";
            this.redoMoveToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.redoMoveToolStripMenuItem.Text = "Redo Move";
            this.redoMoveToolStripMenuItem.Click += new System.EventHandler(this.redoMoveToolStripMenuItem_Click);
            // 
            // setLinkIdToolStripMenuItem
            // 
            this.setLinkIdToolStripMenuItem.Name = "setLinkIdToolStripMenuItem";
            this.setLinkIdToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.setLinkIdToolStripMenuItem.Text = "Set Link Id";
            this.setLinkIdToolStripMenuItem.Click += new System.EventHandler(this.setLinkIdToolStripMenuItem_Click);
            // 
            // mImageList
            // 
            this.mImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mImageList.ImageStream")));
            this.mImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mImageList.Images.SetKeyName(0, "xmlnote.ico");
            this.mImageList.Images.SetKeyName(1, "BlueBall.gif");
            this.mImageList.Images.SetKeyName(2, "cdata.ico");
            this.mImageList.Images.SetKeyName(3, "Copy.bmp");
            this.mImageList.Images.SetKeyName(4, "Cut.bmp");
            this.mImageList.Images.SetKeyName(5, "Delete.bmp");
            this.mImageList.Images.SetKeyName(6, "Element.ICO");
            this.mImageList.Images.SetKeyName(7, "errorlist.bmp");
            this.mImageList.Images.SetKeyName(8, "goleft.bmp");
            this.mImageList.Images.SetKeyName(9, "goright.bmp");
            this.mImageList.Images.SetKeyName(10, "GreenBall.gif");
            this.mImageList.Images.SetKeyName(11, "new.bmp");
            this.mImageList.Images.SetKeyName(12, "NudgeDown.bmp");
            this.mImageList.Images.SetKeyName(13, "NudgeLeft.bmp");
            this.mImageList.Images.SetKeyName(14, "NudgeRight.bmp");
            this.mImageList.Images.SetKeyName(15, "NudgeUp.bmp");
            this.mImageList.Images.SetKeyName(16, "open.bmp");
            this.mImageList.Images.SetKeyName(17, "Open.ico");
            this.mImageList.Images.SetKeyName(18, "parentfolder.bmp");
            this.mImageList.Images.SetKeyName(19, "Paste.bmp");
            this.mImageList.Images.SetKeyName(20, "programicon.png");
            this.mImageList.Images.SetKeyName(21, "PurpleBall.gif");
            this.mImageList.Images.SetKeyName(22, "purple-bullet.gif");
            this.mImageList.Images.SetKeyName(23, "RedBall.gif");
            this.mImageList.Images.SetKeyName(24, "Redo.bmp");
            this.mImageList.Images.SetKeyName(25, "save.bmp");
            this.mImageList.Images.SetKeyName(26, "taskerror.bmp");
            this.mImageList.Images.SetKeyName(27, "taskinfo.bmp");
            this.mImageList.Images.SetKeyName(28, "tasknone.bmp");
            this.mImageList.Images.SetKeyName(29, "taskwarning.bmp");
            this.mImageList.Images.SetKeyName(30, "Text.ICO");
            this.mImageList.Images.SetKeyName(31, "Undo.bmp");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mToolStrip);
            this.splitContainer1.Panel1.Controls.Add(this.mProtocolTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1210, 757);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 1;
            // 
            // mToolStrip
            // 
            this.mToolStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripDropDownButton1,
            this.mSaveToolStripButton,
            this.toolStripButton2,
            this.newToolStripButton,
            this.mUndoToolStripButton,
            this.mRedoToolStripButton,
            this.toolStripButton3,
            this.toolStripButton4,
            this.mAddSectionToolStripButton,
            this.mAddChildToolStripButton,
            this.toolStripButton1});
            this.mToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mToolStrip.Name = "mToolStrip";
            this.mToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mToolStrip.Size = new System.Drawing.Size(403, 26);
            this.mToolStrip.TabIndex = 1;
            this.mToolStrip.Text = "toolStrip1";
            // 
            // fileToolStripDropDownButton1
            // 
            this.fileToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripDropDownButton1.Image")));
            this.fileToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripDropDownButton1.Name = "fileToolStripDropDownButton1";
            this.fileToolStripDropDownButton1.Size = new System.Drawing.Size(46, 23);
            this.fileToolStripDropDownButton1.Text = "File";
            // 
            // neToolStripMenuItem
            // 
            this.neToolStripMenuItem.Name = "neToolStripMenuItem";
            this.neToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.neToolStripMenuItem.Text = "New";
            this.neToolStripMenuItem.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.toolStripMenuItem1.Text = "Open...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.mSaveToolStripButton_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mSaveToolStripButton
            // 
            this.mSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mSaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mSaveToolStripButton.Image")));
            this.mSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mSaveToolStripButton.Name = "mSaveToolStripButton";
            this.mSaveToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.mSaveToolStripButton.Text = "Save";
            this.mSaveToolStripButton.Click += new System.EventHandler(this.mSaveToolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton2.Text = "Open File";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // mUndoToolStripButton
            // 
            this.mUndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mUndoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mUndoToolStripButton.Image")));
            this.mUndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mUndoToolStripButton.Name = "mUndoToolStripButton";
            this.mUndoToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.mUndoToolStripButton.Text = "UNDO";
            this.mUndoToolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // mRedoToolStripButton
            // 
            this.mRedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mRedoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mRedoToolStripButton.Image")));
            this.mRedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mRedoToolStripButton.Name = "mRedoToolStripButton";
            this.mRedoToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.mRedoToolStripButton.Text = "REDO";
            this.mRedoToolStripButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton3.Text = "Up";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "Down";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // mAddSectionToolStripButton
            // 
            this.mAddSectionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAddSectionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mAddSectionToolStripButton.Image")));
            this.mAddSectionToolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mAddSectionToolStripButton.Name = "mAddSectionToolStripButton";
            this.mAddSectionToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.mAddSectionToolStripButton.Text = "Add Section";
            this.mAddSectionToolStripButton.Click += new System.EventHandler(this.mAddSectionToolStripButton_Click);
            // 
            // mAddChildToolStripButton
            // 
            this.mAddChildToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAddChildToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mAddChildToolStripButton.Image")));
            this.mAddChildToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mAddChildToolStripButton.Name = "mAddChildToolStripButton";
            this.mAddChildToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.mAddChildToolStripButton.Text = "+";
            this.mAddChildToolStripButton.ToolTipText = "Add Statement";
            this.mAddChildToolStripButton.Click += new System.EventHandler(this.mAddChildToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "Remove Node";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 549);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.mIdLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mIdLabelValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mLinkLabelText);
            this.groupBox1.Controls.Add(this.mLinkTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 133);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Link Info";
            // 
            // mIdLabel
            // 
            this.mIdLabel.AutoSize = true;
            this.mIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mIdLabel.Location = new System.Drawing.Point(6, 26);
            this.mIdLabel.Name = "mIdLabel";
            this.mIdLabel.Size = new System.Drawing.Size(118, 24);
            this.mIdLabel.TabIndex = 1;
            this.mIdLabel.Text = "Statement Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Link Text:";
            // 
            // mIdLabelValue
            // 
            this.mIdLabelValue.AutoSize = true;
            this.mIdLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mIdLabelValue.Location = new System.Drawing.Point(144, 26);
            this.mIdLabelValue.Name = "mIdLabelValue";
            this.mIdLabelValue.Size = new System.Drawing.Size(114, 24);
            this.mIdLabelValue.TabIndex = 2;
            this.mIdLabelValue.Text = "\"                  \"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Link Id:";
            // 
            // mLinkLabelText
            // 
            this.mLinkLabelText.AutoSize = true;
            this.mLinkLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLinkLabelText.Location = new System.Drawing.Point(144, 50);
            this.mLinkLabelText.Name = "mLinkLabelText";
            this.mLinkLabelText.Size = new System.Drawing.Size(109, 24);
            this.mLinkLabelText.TabIndex = 4;
            this.mLinkLabelText.Text = "\"                 \"";
            // 
            // mLinkTextBox
            // 
            this.mLinkTextBox.Location = new System.Drawing.Point(148, 82);
            this.mLinkTextBox.Name = "mLinkTextBox";
            this.mLinkTextBox.Size = new System.Drawing.Size(614, 26);
            this.mLinkTextBox.TabIndex = 6;
            this.mLinkTextBox.TextChanged += new System.EventHandler(this.mLinkTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mQuestionListComboBox);
            this.groupBox2.Controls.Add(this.removeItemButton);
            this.groupBox2.Controls.Add(this.AddSubTextItemButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 123);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SubText Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "SubText:";
            // 
            // mQuestionListComboBox
            // 
            this.mQuestionListComboBox.FormattingEnabled = true;
            this.mQuestionListComboBox.Location = new System.Drawing.Point(148, 32);
            this.mQuestionListComboBox.Name = "mQuestionListComboBox";
            this.mQuestionListComboBox.Size = new System.Drawing.Size(614, 28);
            this.mQuestionListComboBox.TabIndex = 7;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(295, 66);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(134, 32);
            this.removeItemButton.TabIndex = 10;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // AddSubTextItemButton
            // 
            this.AddSubTextItemButton.Location = new System.Drawing.Point(148, 66);
            this.AddSubTextItemButton.Name = "AddSubTextItemButton";
            this.AddSubTextItemButton.Size = new System.Drawing.Size(131, 32);
            this.AddSubTextItemButton.TabIndex = 9;
            this.AddSubTextItemButton.Text = "Add Item";
            this.AddSubTextItemButton.UseVisualStyleBackColor = true;
            this.AddSubTextItemButton.Click += new System.EventHandler(this.AddSubTextItemButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mDocument);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 208);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statement Info";
            // 
            // mDocument
            // 
            this.mDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDocument.Location = new System.Drawing.Point(3, 22);
            this.mDocument.Name = "mDocument";
            this.mDocument.Size = new System.Drawing.Size(797, 183);
            this.mDocument.TabIndex = 0;
            this.mDocument.Text = "";
            this.mDocument.TextChanged += new System.EventHandler(this.mDocument_TextChanged);
            // 
            // ProtocolEditUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 757);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProtocolEditUi";
            this.Text = "ProtocolEditUi";
            this.mContextMenuStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.mToolStrip.ResumeLayout(false);
            this.mToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mProtocolTreeView;
        private System.Windows.Forms.ContextMenuStrip mContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeChildToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox mDocument;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mToolStrip;
        private System.Windows.Forms.ToolStripButton mUndoToolStripButton;
        private System.Windows.Forms.ToolStripButton mRedoToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ImageList mImageList;
        private System.Windows.Forms.ToolStripButton mAddSectionToolStripButton;
        private System.Windows.Forms.ToolStripButton mAddChildToolStripButton;
        private System.Windows.Forms.Label mIdLabelValue;
        private System.Windows.Forms.Label mIdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem setLinkIdToolStripMenuItem;
        private System.Windows.Forms.TextBox mLinkTextBox;
        private System.Windows.Forms.ComboBox mQuestionListComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddSubTextItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label mLinkLabelText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton mSaveToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}