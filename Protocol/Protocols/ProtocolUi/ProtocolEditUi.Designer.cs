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
            this.mImageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mToolStrip = new System.Windows.Forms.ToolStrip();
            this.mUndoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mRedoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.mSaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mAddSectionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mAddChildToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mDocument = new System.Windows.Forms.RichTextBox();
            this.mContextMenuStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mToolStrip.SuspendLayout();
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
            this.mProtocolTreeView.Name = "mProtocolTreeView";
            this.mProtocolTreeView.SelectedImageIndex = 30;
            this.mProtocolTreeView.Size = new System.Drawing.Size(403, 757);
            this.mProtocolTreeView.TabIndex = 0;
            this.mProtocolTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            this.mProtocolTreeView.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.mProtocolTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mProtocolTreeView_AfterSelect);
            this.mProtocolTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mProtocolTreeView_MouseUp);
            this.mProtocolTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tree_DragEnter);
            this.mProtocolTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Tree_ItemDrag);
            this.mProtocolTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mProtocolTreeView_MouseDown);
            // 
            // mContextMenuStrip
            // 
            this.mContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChildToolStripMenuItem,
            this.removeChildToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.undoMoveToolStripMenuItem,
            this.redoMoveToolStripMenuItem});
            this.mContextMenuStrip.Name = "mContextMenuStrip";
            this.mContextMenuStrip.Size = new System.Drawing.Size(194, 124);
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
            this.splitContainer1.Panel2.Controls.Add(this.mDocument);
            this.splitContainer1.Size = new System.Drawing.Size(1210, 757);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 1;
            // 
            // mToolStrip
            // 
            this.mToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUndoToolStripButton,
            this.mRedoToolStripButton,
            this.toolStripButton3,
            this.toolStripButton4,
            this.mSaveToolStripButton,
            this.mAddSectionToolStripButton,
            this.mAddChildToolStripButton});
            this.mToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mToolStrip.Name = "mToolStrip";
            this.mToolStrip.Size = new System.Drawing.Size(403, 26);
            this.mToolStrip.TabIndex = 1;
            this.mToolStrip.Text = "toolStrip1";
            // 
            // mUndoToolStripButton
            // 
            this.mUndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mUndoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mUndoToolStripButton.Image")));
            this.mUndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mUndoToolStripButton.Name = "mUndoToolStripButton";
            this.mUndoToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.mUndoToolStripButton.Text = "UNDO";
            this.mUndoToolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // mRedoToolStripButton
            // 
            this.mRedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mRedoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mRedoToolStripButton.Image")));
            this.mRedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mRedoToolStripButton.Name = "mRedoToolStripButton";
            this.mRedoToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.mRedoToolStripButton.Text = "REDO";
            this.mRedoToolStripButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton3.Text = "Up";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton4.Text = "Down";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // mSaveToolStripButton
            // 
            this.mSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mSaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mSaveToolStripButton.Image")));
            this.mSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mSaveToolStripButton.Name = "mSaveToolStripButton";
            this.mSaveToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.mSaveToolStripButton.Text = "save";
            this.mSaveToolStripButton.Click += new System.EventHandler(this.mSaveToolStripButton_Click);
            // 
            // mAddSectionToolStripButton
            // 
            this.mAddSectionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mAddSectionToolStripButton.Image")));
            this.mAddSectionToolStripButton.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mAddSectionToolStripButton.Name = "mAddSectionToolStripButton";
            this.mAddSectionToolStripButton.Size = new System.Drawing.Size(41, 23);
            this.mAddSectionToolStripButton.Text = "+";
            this.mAddSectionToolStripButton.Click += new System.EventHandler(this.mAddSectionToolStripButton_Click);
            // 
            // mAddChildToolStripButton
            // 
            this.mAddChildToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mAddChildToolStripButton.Image")));
            this.mAddChildToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mAddChildToolStripButton.Name = "mAddChildToolStripButton";
            this.mAddChildToolStripButton.Size = new System.Drawing.Size(41, 23);
            this.mAddChildToolStripButton.Text = "+";
            this.mAddChildToolStripButton.Click += new System.EventHandler(this.mAddChildToolStripButton_Click);
            // 
            // mDocument
            // 
            this.mDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.mDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDocument.Location = new System.Drawing.Point(0, 0);
            this.mDocument.Name = "mDocument";
            this.mDocument.Size = new System.Drawing.Size(803, 327);
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
        private System.Windows.Forms.ToolStripButton mSaveToolStripButton;
        private System.Windows.Forms.ImageList mImageList;
        private System.Windows.Forms.ToolStripButton mAddSectionToolStripButton;
        private System.Windows.Forms.ToolStripButton mAddChildToolStripButton;
    }
}