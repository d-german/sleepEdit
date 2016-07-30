using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using BMIcalc;
using NetSpell.SpellChecker;
using NetSpell.SpellChecker.Dictionary;
using Protocols;
using ProtocolUi;
using WFHost;
//using System.Runtime.Serialization.Formatters.Soap;


namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for PrelimInter.
    /// </summary>
    public class sleepEdit : Form
    {
        public sleepEdit()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            getSettings();
            try
            {
                mManager = new SleepEditDataManager();
            }
            catch
            {
                MessageBox.Show("sleepEditData.xml not found");
            }
            ProtocolManager.DefaultPath = protocolPath;
            try
            {
                wordDictionary1.DictionaryFolder = dictionaryPath;
            }
            catch
            {
                MessageBox.Show("Warning, Dictionary file not found-Spell Checker will not Function", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                menuItem_spelling.Enabled = false;
            }
        }

        /// <summary>
        ///     Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            saveSettings();
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(sleepEdit));
            this.editToolBar = new System.Windows.Forms.ToolBar();
            this.newBarButton = new System.Windows.Forms.ToolBarButton();
            this.openBarButton = new System.Windows.Forms.ToolBarButton();
            this.saveBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.printBarButton = new System.Windows.Forms.ToolBarButton();
            this.printPreviewBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.spellBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.cutBarButton = new System.Windows.Forms.ToolBarButton();
            this.copyBarButton = new System.Windows.Forms.ToolBarButton();
            this.pasteBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.undoBarButton = new System.Windows.Forms.ToolBarButton();
            this.redoBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
            this.fontBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.boldBarButton = new System.Windows.Forms.ToolBarButton();
            this.italicBarButton = new System.Windows.Forms.ToolBarButton();
            this.underlineBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.leftBarButton = new System.Windows.Forms.ToolBarButton();
            this.centerBarButton = new System.Windows.Forms.ToolBarButton();
            this.rightBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
            this.bulletsBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.fontColorBarButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarImages = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_new = new System.Windows.Forms.MenuItem();
            this.menuItem_open = new System.Windows.Forms.MenuItem();
            this.menuItem_save = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem_print = new System.Windows.Forms.MenuItem();
            this.menuItem_pageSetup = new System.Windows.Forms.MenuItem();
            this.menuItem_printPreview = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_exit = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem_undo = new System.Windows.Forms.MenuItem();
            this.menuItem_redo = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem_cut = new System.Windows.Forms.MenuItem();
            this.menuItem_copy = new System.Windows.Forms.MenuItem();
            this.menuItem_paste = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem_selectAll = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem_wordwrap = new System.Windows.Forms.MenuItem();
            this.menuItem_font = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.bmiCalcMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem_spelling = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.wordDictionary1 = new NetSpell.SpellChecker.Dictionary.WordDictionary(this.components);
            this.spelling = new NetSpell.SpellChecker.Spelling(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.document = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
            this.SuspendLayout();
            // 
            // editToolBar
            // 
            this.editToolBar.AutoSize = false;
            this.editToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[]
            {
                this.newBarButton,
                this.openBarButton,
                this.saveBarButton,
                this.toolBarButton4,
                this.printBarButton,
                this.printPreviewBarButton,
                this.toolBarButton5,
                this.spellBarButton,
                this.toolBarButton1,
                this.cutBarButton,
                this.copyBarButton,
                this.pasteBarButton,
                this.toolBarButton8,
                this.undoBarButton,
                this.redoBarButton,
                this.toolBarButton11,
                this.fontBarButton,
                this.toolBarButton2,
                this.boldBarButton,
                this.italicBarButton,
                this.underlineBarButton,
                this.toolBarButton6,
                this.leftBarButton,
                this.centerBarButton,
                this.rightBarButton,
                this.toolBarButton12,
                this.bulletsBarButton,
                this.toolBarButton3,
                this.fontColorBarButton
            });
            this.editToolBar.ButtonSize = new System.Drawing.Size(20, 20);
            this.editToolBar.DropDownArrows = true;
            this.editToolBar.ImageList = this.toolBarImages;
            this.editToolBar.Location = new System.Drawing.Point(0, 0);
            this.editToolBar.Margin = new System.Windows.Forms.Padding(0);
            this.editToolBar.Name = "editToolBar";
            this.editToolBar.ShowToolTips = true;
            this.editToolBar.Size = new System.Drawing.Size(937, 35);
            this.editToolBar.TabIndex = 5;
            this.editToolBar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.editToolBar.Wrappable = false;
            this.editToolBar.ButtonClick +=
                new System.Windows.Forms.ToolBarButtonClickEventHandler(this.editToolBar_ButtonClick);
            // 
            // newBarButton
            // 
            this.newBarButton.ImageIndex = 4;
            this.newBarButton.Name = "newBarButton";
            // 
            // openBarButton
            // 
            this.openBarButton.ImageIndex = 5;
            this.openBarButton.Name = "openBarButton";
            this.openBarButton.ToolTipText = "Open";
            // 
            // saveBarButton
            // 
            this.saveBarButton.ImageIndex = 8;
            this.saveBarButton.Name = "saveBarButton";
            this.saveBarButton.ToolTipText = "Save";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // printBarButton
            // 
            this.printBarButton.ImageIndex = 7;
            this.printBarButton.Name = "printBarButton";
            this.printBarButton.ToolTipText = "Print";
            // 
            // printPreviewBarButton
            // 
            this.printPreviewBarButton.ImageIndex = 3;
            this.printPreviewBarButton.Name = "printPreviewBarButton";
            this.printPreviewBarButton.ToolTipText = "Print Preview";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // spellBarButton
            // 
            this.spellBarButton.ImageIndex = 9;
            this.spellBarButton.Name = "spellBarButton";
            this.spellBarButton.ToolTipText = "Spell Check";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // cutBarButton
            // 
            this.cutBarButton.ImageIndex = 1;
            this.cutBarButton.Name = "cutBarButton";
            this.cutBarButton.ToolTipText = "Cut";
            // 
            // copyBarButton
            // 
            this.copyBarButton.ImageIndex = 0;
            this.copyBarButton.Name = "copyBarButton";
            this.copyBarButton.ToolTipText = "Copy";
            // 
            // pasteBarButton
            // 
            this.pasteBarButton.ImageIndex = 6;
            this.pasteBarButton.Name = "pasteBarButton";
            this.pasteBarButton.ToolTipText = "Paste";
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.Name = "toolBarButton8";
            this.toolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // undoBarButton
            // 
            this.undoBarButton.ImageIndex = 10;
            this.undoBarButton.Name = "undoBarButton";
            this.undoBarButton.ToolTipText = "Undo";
            // 
            // redoBarButton
            // 
            this.redoBarButton.ImageIndex = 11;
            this.redoBarButton.Name = "redoBarButton";
            this.redoBarButton.ToolTipText = "Redo";
            // 
            // toolBarButton11
            // 
            this.toolBarButton11.Name = "toolBarButton11";
            this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // fontBarButton
            // 
            this.fontBarButton.ImageIndex = 13;
            this.fontBarButton.Name = "fontBarButton";
            this.fontBarButton.ToolTipText = "Font";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // boldBarButton
            // 
            this.boldBarButton.ImageIndex = 14;
            this.boldBarButton.Name = "boldBarButton";
            this.boldBarButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.boldBarButton.ToolTipText = "Bold";
            // 
            // italicBarButton
            // 
            this.italicBarButton.ImageIndex = 15;
            this.italicBarButton.Name = "italicBarButton";
            this.italicBarButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.italicBarButton.ToolTipText = "Italic";
            // 
            // underlineBarButton
            // 
            this.underlineBarButton.ImageIndex = 16;
            this.underlineBarButton.Name = "underlineBarButton";
            this.underlineBarButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.underlineBarButton.ToolTipText = "Underline";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // leftBarButton
            // 
            this.leftBarButton.ImageIndex = 17;
            this.leftBarButton.Name = "leftBarButton";
            this.leftBarButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.leftBarButton.ToolTipText = "Align Left";
            // 
            // centerBarButton
            // 
            this.centerBarButton.ImageIndex = 18;
            this.centerBarButton.Name = "centerBarButton";
            this.centerBarButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.centerBarButton.ToolTipText = "Align Center";
            // 
            // rightBarButton
            // 
            this.rightBarButton.ImageIndex = 19;
            this.rightBarButton.Name = "rightBarButton";
            this.rightBarButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.rightBarButton.ToolTipText = "Align Right";
            // 
            // toolBarButton12
            // 
            this.toolBarButton12.Name = "toolBarButton12";
            this.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // bulletsBarButton
            // 
            this.bulletsBarButton.ImageIndex = 20;
            this.bulletsBarButton.Name = "bulletsBarButton";
            this.bulletsBarButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.bulletsBarButton.ToolTipText = "Bullets";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // fontColorBarButton
            // 
            this.fontColorBarButton.ImageIndex = 22;
            this.fontColorBarButton.Name = "fontColorBarButton";
            this.fontColorBarButton.ToolTipText = "Font Color";
            // 
            // toolBarImages
            // 
            this.toolBarImages.ImageStream =
                ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("toolBarImages.ImageStream")));
            this.toolBarImages.TransparentColor = System.Drawing.Color.Transparent;
            this.toolBarImages.Images.SetKeyName(0, "");
            this.toolBarImages.Images.SetKeyName(1, "");
            this.toolBarImages.Images.SetKeyName(2, "");
            this.toolBarImages.Images.SetKeyName(3, "");
            this.toolBarImages.Images.SetKeyName(4, "");
            this.toolBarImages.Images.SetKeyName(5, "");
            this.toolBarImages.Images.SetKeyName(6, "");
            this.toolBarImages.Images.SetKeyName(7, "");
            this.toolBarImages.Images.SetKeyName(8, "");
            this.toolBarImages.Images.SetKeyName(9, "");
            this.toolBarImages.Images.SetKeyName(10, "");
            this.toolBarImages.Images.SetKeyName(11, "");
            this.toolBarImages.Images.SetKeyName(12, "");
            this.toolBarImages.Images.SetKeyName(13, "");
            this.toolBarImages.Images.SetKeyName(14, "");
            this.toolBarImages.Images.SetKeyName(15, "");
            this.toolBarImages.Images.SetKeyName(16, "");
            this.toolBarImages.Images.SetKeyName(17, "");
            this.toolBarImages.Images.SetKeyName(18, "");
            this.toolBarImages.Images.SetKeyName(19, "");
            this.toolBarImages.Images.SetKeyName(20, "");
            this.toolBarImages.Images.SetKeyName(21, "");
            this.toolBarImages.Images.SetKeyName(22, "");
            this.toolBarImages.Images.SetKeyName(23, "");
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem14,
                this.menuItem15,
                this.menuItem17,
                this.menuItem18
            });
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 0;
            this.menuItem14.Text = "Copy";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click_1);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 1;
            this.menuItem15.Text = "Cut";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click_1);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 2;
            this.menuItem17.Text = "Paste";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 3;
            this.menuItem18.Text = "Select All";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem1,
                this.menuItem4,
                this.menuItem13,
                this.menuItem5,
                this.menuItem16,
                this.menuItem19,
                this.menuItem25
            });
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem_new,
                this.menuItem_open,
                this.menuItem_save,
                this.menuItem2,
                this.menuItem_print,
                this.menuItem_pageSetup,
                this.menuItem_printPreview,
                this.menuItem3,
                this.menuItem_exit
            });
            this.menuItem1.Text = "File";
            // 
            // menuItem_new
            // 
            this.menuItem_new.Index = 0;
            this.menuItem_new.Text = "New";
            this.menuItem_new.Click += new System.EventHandler(this.menuItem_new_Click);
            // 
            // menuItem_open
            // 
            this.menuItem_open.Index = 1;
            this.menuItem_open.Text = "Open";
            this.menuItem_open.Click += new System.EventHandler(this.menuItem_open_Click);
            // 
            // menuItem_save
            // 
            this.menuItem_save.Index = 2;
            this.menuItem_save.Text = "Save";
            this.menuItem_save.Click += new System.EventHandler(this.menuItem_save_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "-";
            // 
            // menuItem_print
            // 
            this.menuItem_print.Index = 4;
            this.menuItem_print.Text = "Print";
            this.menuItem_print.Click += new System.EventHandler(this.menuItem_print_Click);
            // 
            // menuItem_pageSetup
            // 
            this.menuItem_pageSetup.Index = 5;
            this.menuItem_pageSetup.Text = "Page Setup";
            this.menuItem_pageSetup.Click += new System.EventHandler(this.menuItem_pageSetup_Click);
            // 
            // menuItem_printPreview
            // 
            this.menuItem_printPreview.Index = 6;
            this.menuItem_printPreview.Text = "Print Preview";
            this.menuItem_printPreview.Click += new System.EventHandler(this.menuItem_printPreview_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 7;
            this.menuItem3.Text = "-";
            // 
            // menuItem_exit
            // 
            this.menuItem_exit.Index = 8;
            this.menuItem_exit.Text = "Exit";
            this.menuItem_exit.Click += new System.EventHandler(this.menuItem_exit_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem_undo,
                this.menuItem_redo,
                this.menuItem7,
                this.menuItem_cut,
                this.menuItem_copy,
                this.menuItem_paste,
                this.menuItem11,
                this.menuItem_selectAll
            });
            this.menuItem4.Text = "Edit";
            // 
            // menuItem_undo
            // 
            this.menuItem_undo.Index = 0;
            this.menuItem_undo.Text = "Undo";
            this.menuItem_undo.Click += new System.EventHandler(this.menuItem_undo_Click);
            // 
            // menuItem_redo
            // 
            this.menuItem_redo.Index = 1;
            this.menuItem_redo.Text = "Redo";
            this.menuItem_redo.Click += new System.EventHandler(this.menuItem_redo_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "-";
            // 
            // menuItem_cut
            // 
            this.menuItem_cut.Index = 3;
            this.menuItem_cut.Text = "Cut";
            this.menuItem_cut.Click += new System.EventHandler(this.menuItem_cut_Click);
            // 
            // menuItem_copy
            // 
            this.menuItem_copy.Index = 4;
            this.menuItem_copy.Text = "Copy";
            this.menuItem_copy.Click += new System.EventHandler(this.menuItem_copy_Click);
            // 
            // menuItem_paste
            // 
            this.menuItem_paste.Index = 5;
            this.menuItem_paste.Text = "Paste";
            this.menuItem_paste.Click += new System.EventHandler(this.menuItem_paste_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 6;
            this.menuItem11.Text = "-";
            // 
            // menuItem_selectAll
            // 
            this.menuItem_selectAll.Index = 7;
            this.menuItem_selectAll.Text = "Select All";
            this.menuItem_selectAll.Click += new System.EventHandler(this.menuItem_selectAll_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem_wordwrap,
                this.menuItem_font
            });
            this.menuItem13.Text = "Format";
            // 
            // menuItem_wordwrap
            // 
            this.menuItem_wordwrap.Checked = true;
            this.menuItem_wordwrap.Index = 0;
            this.menuItem_wordwrap.Text = "Word Wrap";
            // 
            // menuItem_font
            // 
            this.menuItem_font.Index = 1;
            this.menuItem_font.Text = "Font...";
            this.menuItem_font.Click += new System.EventHandler(this.menuItem_font_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.DefaultItem = true;
            this.menuItem5.Index = 3;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem6,
                this.menuItem8,
                this.menuItem9,
                this.menuItem10,
                this.menuItem12,
                this.bmiCalcMenuItem
            });
            this.menuItem5.Text = "Sleep Tools";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItem6.Text = "Protocol";
            this.menuItem6.Click += new System.EventHandler(this.sleepProtocol_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.menuItem8.Text = "Tech Note";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.menuItem9.Text = "Preliminary Interp";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 3;
            this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.F4;
            this.menuItem10.Text = "Med List";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 4;
            this.menuItem12.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuItem12.Text = "ABG Decoder";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click_1);
            // 
            // bmiCalcMenuItem
            // 
            this.bmiCalcMenuItem.Index = 5;
            this.bmiCalcMenuItem.Text = "BMI Caculator";
            this.bmiCalcMenuItem.Click += new System.EventHandler(this.bmiCalcMenuItem_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 4;
            this.menuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem_spelling
            });
            this.menuItem16.Text = "Tools";
            // 
            // menuItem_spelling
            // 
            this.menuItem_spelling.Index = 0;
            this.menuItem_spelling.Shortcut = System.Windows.Forms.Shortcut.F7;
            this.menuItem_spelling.Text = "Spelling ...";
            this.menuItem_spelling.Click += new System.EventHandler(this.menuItem_spelling_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 5;
            this.menuItem19.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem20,
                this.menuItem26
            });
            this.menuItem19.Text = "Utilities";
            this.menuItem19.Popup += new System.EventHandler(this.menuItem19_Popup);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 0;
            this.menuItem20.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem21,
                this.menuItem23,
                this.menuItem22,
                this.menuItem24
            });
            this.menuItem20.Text = "Med List";
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 0;
            this.menuItem21.Text = "Remove Duplicates";
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 1;
            this.menuItem23.Text = "Remove Flags";
            this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 2;
            this.menuItem22.Text = "Format List to lowercase";
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 3;
            this.menuItem24.Text = "Remove  Med From List";
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 1;
            this.menuItem26.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem28,
                this.menuItem29,
                this.menuItem27
            });
            this.menuItem26.Text = "Protocol";
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 0;
            this.menuItem28.Text = "Protocol Editor";
            this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 1;
            this.menuItem29.Text = "Set Default Protocol";
            this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 2;
            this.menuItem27.Text = "Default Location to sleepEditData.xml";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 6;
            this.menuItem25.Text = "About";
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "RTF Document (*.rtf)|*.rtf|Text Documents (*.txt)|*.txt";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RTF Document (*.rtf)|*.rtf|Text Documents (*.txt)|*.txt";
            // 
            // printDialog1
            // 
            this.printDialog1.AllowPrintToFile = false;
            this.printDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint +=
                new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage +=
                new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon) (resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // spelling
            // 
            this.spelling.Dictionary = this.wordDictionary1;
            this.spelling.DeletedWord +=
                new NetSpell.SpellChecker.Spelling.DeletedWordEventHandler(this.spelling_DeletedWord);
            this.spelling.ReplacedWord +=
                new NetSpell.SpellChecker.Spelling.ReplacedWordEventHandler(this.spelling_ReplacedWord);
            // 
            // document
            // 
            this.document.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.document.BulletIndent = 5;
            this.document.ContextMenu = this.contextMenu;
            this.document.DetectUrls = false;
            this.document.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.document.Location = new System.Drawing.Point(8, 40);
            this.document.Name = "document";
            this.document.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.document.Size = new System.Drawing.Size(935, 370);
            this.document.TabIndex = 6;
            this.document.Text = "";
            this.document.SelectionChanged += new System.EventHandler(this.document_SelectionChanged);
            // 
            // sleepEdit
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(937, 415);
            this.Controls.Add(this.document);
            this.Controls.Add(this.editToolBar);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "sleepEdit";
            this.Text = "Sleep Edit";
            this.ResumeLayout(false);
        }

        #endregion

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new sleepEdit());
        }

        private void getSettings()
        {
            var fileName = Application.StartupPath + @"\settings.ini";
            var bf = new BinaryFormatter();
            try
            {
                using (Stream stream = new FileStream(fileName, FileMode.Open))
                {
                    try
                    {
                        var s = new settings();
                        s = (settings) bf.Deserialize(stream);
                        //sleepEdit.medPath = s.medListFileName;
                        prelimIntPath = s.prelimIntFileName;
                        workDirPath = s.workDirPath;
                        techList = s.techList;
                        maskType = s.maskType;
                        maskSize = s.maskSize;
                        protocolTitle = s.protocolTitle;
                        if (!ProtocolManager.IsValidPath(s.protocalPath))
                        {
                            getPathToTheMainProtocolFile();
                        }
                        else
                        {
                            protocolPath = s.protocalPath;
                        }
                        sleepEditDataPath = s.sleepEditDataPath;

                        if (!SleepEditDataManager.isValidPath(sleepEditDataPath))
                        {
                            sleepEditDataPath = Application.StartupPath + @"\data files\sleepEditData.xml";

                            if (!SleepEditDataManager.isValidPath(sleepEditDataPath))
                            {
                                getPathToSleepEditDataFile();
                            }
                        }
                        SleepEditDataManager.mPath = sleepEditDataPath;
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
                MessageBox.Show("settings.ini file not found!!\r\nA new one will be created.");
                Stream stream = new FileStream(fileName, FileMode.Create);
                stream.Close();
            }
        }

        private void getPathToSleepEditDataFile()
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Open sleepEditDataFile.xml ";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            dlg.InitialDirectory = Application.StartupPath + @"\data files";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sleepEditDataPath = dlg.FileName;
                SleepEditDataManager.mPath = dlg.FileName;
            }
        }

        private void getPathToTheMainProtocolFile()
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Open XML Document";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            dlg.InitialDirectory = Application.StartupPath + @"\protocols";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                protocolPath = dlg.FileName;
                ProtocolManager.DefaultPath = dlg.FileName;
            }
        }

        private void saveSettings()
        {
            var fileName = Application.StartupPath + @"\settings.ini";
            var bf = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Open))
            {
                var s = new settings();
                // s.medListFileName = sleepEdit.medPath;
                s.prelimIntFileName = prelimIntPath;
                s.workDirPath = workDirPath;
                s.techList = techList;
                s.maskType = maskType;
                s.maskSize = maskSize;
                s.protocolTitle = protocolTitle;
                s.protocalPath = protocolPath;
                s.sleepEditDataPath = sleepEditDataPath;
                bf.Serialize(stream, s);
            }
        }

        private void menuItem_new_Click(object sender, EventArgs e)
        {
            Text = "Untitled";
            fileName = "Untitled";
            document.Clear();
        }

        private void menuItem_open_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            // Create an OpenFileDialog to request a file to open.
            //OpenFileDialog openFile1 = new OpenFileDialog();	
            //this.openFileDialog1.Filter= "RTF Document (*.rtf)|*.rtf|Text Documents (*.txt)|*.txt";
            openFileDialog1.Filter = "Text Documents (*.txt)|*.txt|RTF Document (*.rtf)|*.rtf";
            openFileDialog1.InitialDirectory = workDirPath;


            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
            {
                workDirPath = Environment.CurrentDirectory;
                // Load the contents of the file into the RichTextBox.
                if (openFileDialog1.FileName.EndsWith("rtf"))
                    document.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else
                    document.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuItem_printPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void menuItem_print_Click(object sender, EventArgs e)
        {
            printDocument();
        }


        private void printDocument()
        {
            try
            {
                if (document.SelectionLength != 0)
                {
                    printDialog1.AllowSelection = true;
                    //this.printDialog1.PrinterSettings.PrintRange = PrintRange.Selection;
                }


                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;

                    printDocument1.Print();
                }
            }
            catch
            {
                MessageBox.Show("Printer not available!!");
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            if (document.SelectionLength != 0 && printDocument1.PrinterSettings.PrintRange == PrintRange.Selection)
                checkPrint = document.SelectionStart;
            else

                checkPrint = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                if (document.SelectionLength != 0 && printDocument1.PrinterSettings.PrintRange == PrintRange.Selection)
                {
                    checkPrint = document.Print(document.SelectionStart,
                        document.SelectionStart + document.SelectionLength, e);
                    if (checkPrint < document.SelectionLength)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;
                }
                else
                {
                    checkPrint = document.Print(checkPrint, document.TextLength, e);
                    if (checkPrint < document.TextLength)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;
                }
            }
            catch
            {
                MessageBox.Show("Printer not available!!");
            }
        }

        private void menuItem_pageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void menuItem_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem_spelling_Click(object sender, EventArgs e)
        {
            checkSpelling();
        }

        private void checkSpelling()
        {
            try
            {
                wordDictionary1.DictionaryFolder = dictionaryPath;
                if (document.SelectedText != "")
                    spelling.Text = document.SelectedText;
                else
                    spelling.Text = document.Text;
                spelling.SpellCheck();
            }
            catch
            {
                MessageBox.Show("Warning, Dictionary file not found-Spell Checker will not Function", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                menuItem_spelling.Enabled = false;
            }
        }

        private void spelling_DeletedWord(object sender, SpellingEventArgs e)
        {
            var start = document.SelectionStart;
            var length = document.SelectionLength;

            document.Select(e.TextIndex, e.Word.Length);
            document.SelectedText = "";

            if (start > document.Text.Length)
                start = document.Text.Length;

            if (start + length > document.Text.Length)
                length = 0;

            document.Select(start, length);
        }

        private void spelling_ReplacedWord(object sender, ReplaceWordEventArgs e)
        {
            var start = document.SelectionStart;
            var length = document.SelectionLength;

            document.Select(e.TextIndex, e.Word.Length);
            document.SelectedText = e.ReplacementWord;

            if (start > document.Text.Length)
                start = document.Text.Length;

            if (start + length > document.Text.Length)
                length = 0;

            document.Select(start, length);
        }

        private void menuItem_save_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            if (fileName != "Untitled")
            {
                document.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                saveFileDialog1.InitialDirectory = workDirPath;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    workDirPath = Environment.CurrentDirectory;

                    if (saveFileDialog1.FilterIndex == 1)
                    {
                        saveFileDialog1.DefaultExt = ".rtf";
                        fileName = saveFileDialog1.FileName;
                        document.SaveFile(fileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        saveFileDialog1.DefaultExt = ".txt";
                        fileName = saveFileDialog1.FileName;
                        document.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                    }

                    SetFormTitle();
                }
            }
        }

        protected void SetFormTitle()
        {
            var fileinfo = new FileInfo(fileName);
            Text = fileinfo.Name;
        }

        private void SaveFile()
        {
            try
            {
                Stream stream = File.OpenWrite(fileName);
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(document.Text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuItem_undo_Click(object sender, EventArgs e)
        {
            document.Undo();
        }

        private void menuItem_redo_Click(object sender, EventArgs e)
        {
            document.Redo();
        }

        private void menuItem_cut_Click(object sender, EventArgs e)
        {
            document.Cut();
        }

        private void menuItem_copy_Click(object sender, EventArgs e)
        {
            document.Copy();
        }

        private void menuItem_paste_Click(object sender, EventArgs e)
        {
            document.Paste();
        }

        private void menuItem_selectAll_Click(object sender, EventArgs e)
        {
            document.SelectAll();
        }

        private void menuItem_font_Click(object sender, EventArgs e)
        {
            setFont();
        }

        private void setFont()
        {
            fontDialog1.Font = document.SelectionFont;
            if (fontDialog1.ShowDialog(this) == DialogResult.OK)
            {
                document.SelectionFont = fontDialog1.Font;
            }
        }

        private void setFontColor()
        {
            colorDialog1.Color = document.SelectionColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                document.SelectionColor = colorDialog1.Color;
            }
        }

        private void editToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == newBarButton)
            {
                fileName = "Untitled";
                Text = "Untitled";
                document.Clear();
            }
            else if (e.Button == openBarButton)
            {
                OpenFile();
            }
            else if (e.Button == cutBarButton)
            {
                document.Cut();
            }
            else if (e.Button == copyBarButton)
            {
                document.Copy();
            }
            else if (e.Button == pasteBarButton)
            {
                document.Paste();
            }
            else if (e.Button == printBarButton)
            {
                try
                {
                    printDocument1.Print();
                }
                catch
                {
                    MessageBox.Show("Printer not available!!");
                }
            }
            else if (e.Button == printPreviewBarButton)
            {
                try
                {
                    printPreviewDialog1.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Printer not available!!");
                }
            }
            else if (e.Button == redoBarButton)
            {
                document.Redo();
            }
            else if (e.Button == saveBarButton)
            {
                saveFile();
            }
            else if (e.Button == spellBarButton)
            {
                checkSpelling();
            }
            else if (e.Button == undoBarButton)
            {
                document.Undo();
            }

            else if (e.Button == fontBarButton)
            {
                setFont();
            }
            else if (e.Button == boldBarButton || e.Button == italicBarButton || e.Button == underlineBarButton)
            {
                if (document.SelectionFont != null)
                {
                    var currentFont = document.SelectionFont;
                    var newFontStyle = FontStyle.Regular;

                    if (boldBarButton.Pushed)
                        newFontStyle |= FontStyle.Bold;
                    if (italicBarButton.Pushed)
                        newFontStyle |= FontStyle.Italic;
                    if (underlineBarButton.Pushed)
                        newFontStyle |= FontStyle.Underline;


                    document.SelectionFont = new Font(
                        currentFont.FontFamily,
                        currentFont.Size,
                        newFontStyle
                        );
                }
            }

            else if (e.Button == leftBarButton)
            {
                leftBarButton.Pushed = true;
                centerBarButton.Pushed = false;
                rightBarButton.Pushed = false;
                document.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (e.Button == centerBarButton)
            {
                leftBarButton.Pushed = false;
                centerBarButton.Pushed = true;
                rightBarButton.Pushed = false;
                document.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (e.Button == rightBarButton)
            {
                centerBarButton.Pushed = false;
                leftBarButton.Pushed = false;
                rightBarButton.Pushed = true;
                document.SelectionAlignment = HorizontalAlignment.Right;
            }
            else if (e.Button == bulletsBarButton)
            {
                if (bulletsBarButton.Pushed)
                {
                    document.SelectionBullet = true;
                }
                else
                    document.SelectionBullet = false;
            }

            else if (e.Button == fontColorBarButton)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    document.SelectionColor = colorDialog1.Color;
            }
        }

        private void DisableEditButtons()
        {
            saveBarButton.Enabled = false;
            printBarButton.Enabled = false;
            printPreviewBarButton.Enabled = false;
            spellBarButton.Enabled = false;
            cutBarButton.Enabled = false;
            copyBarButton.Enabled = false;
            pasteBarButton.Enabled = false;
            undoBarButton.Enabled = false;
            redoBarButton.Enabled = false;

            fontBarButton.Enabled = false;
            boldBarButton.Enabled = false;
            italicBarButton.Enabled = false;
            underlineBarButton.Enabled = false;
            leftBarButton.Enabled = false;
            centerBarButton.Enabled = false;
            rightBarButton.Enabled = false;
            bulletsBarButton.Enabled = false;
            fontColorBarButton.Enabled = false;
        }

        private void EnableEditButtons()
        {
            saveBarButton.Enabled = true;
            printBarButton.Enabled = true;
            printPreviewBarButton.Enabled = true;
            spellBarButton.Enabled = true;
            cutBarButton.Enabled = true;
            copyBarButton.Enabled = true;
            pasteBarButton.Enabled = true;
            undoBarButton.Enabled = true;
            redoBarButton.Enabled = true;

            fontBarButton.Enabled = true;
            boldBarButton.Enabled = true;
            italicBarButton.Enabled = true;
            underlineBarButton.Enabled = true;
            leftBarButton.Enabled = true;
            centerBarButton.Enabled = true;
            rightBarButton.Enabled = true;
            bulletsBarButton.Enabled = true;
            fontColorBarButton.Enabled = true;
        }

        private void document_SelectionChanged(object sender, EventArgs e)
        {
            //this.UpdateButtons(document.SelectionFont.Style, 
            //	document.SelectionBullet,
            //	document.SelectionAlignment);
        }

        internal void UpdateButtons(FontStyle style, bool bullet, HorizontalAlignment alignment)
        {
            if ((style & FontStyle.Bold) == FontStyle.Bold)
                boldBarButton.Pushed = true;
            else
                boldBarButton.Pushed = false;

            if ((style & FontStyle.Italic) == FontStyle.Italic)
                italicBarButton.Pushed = true;
            else
                italicBarButton.Pushed = false;

            if ((style & FontStyle.Underline) == FontStyle.Underline)
                underlineBarButton.Pushed = true;
            else
                underlineBarButton.Pushed = false;

            bulletsBarButton.Pushed = bullet;

            switch (alignment)
            {
                case HorizontalAlignment.Left:
                    leftBarButton.Pushed = true;
                    centerBarButton.Pushed = false;
                    rightBarButton.Pushed = false;
                    break;
                case HorizontalAlignment.Center:
                    leftBarButton.Pushed = false;
                    centerBarButton.Pushed = true;
                    rightBarButton.Pushed = false;
                    break;
                case HorizontalAlignment.Right:
                    leftBarButton.Pushed = false;
                    centerBarButton.Pushed = false;
                    rightBarButton.Pushed = true;
                    break;
            }
        }

        private void menuItem_wordwrap_Click(object sender, EventArgs e)
        {
            if (document.WordWrap)
            {
                menuItem_wordwrap.Checked = false;
                document.WordWrap = false;
            }
            else
            {
                menuItem_wordwrap.Checked = true;
                document.WordWrap = true;
            }
        }

        private void PassData(object sender)
        {
            var str = (string) sender + "\r\n";
            document.AppendText(str);
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            var sleepInterp = new PrelimInter();
            sleepInterp.Show();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            var sleepNote = new TechNote();
            sleepNote.passControl += PassData;
            sleepNote.Show();
        }

        private void sleepProtocol_Click(object sender, EventArgs e)
        {
            //99999+
            SetSleepProtocolTitle();
            //99999-

            var protocol = new Protocol();


            if (protocol.ShowDialog() == DialogResult.OK)
            {
                // this.document.Text = protocol.document.Text;
                document.Rtf = protocol.document.Rtf;


                for (var i = 0; i < document.Text.Length;)
                {
                    document.Find("GOAL", i,
                        RichTextBoxFinds.MatchCase);

                    document.SelectionFont = new Font("SansSerif", 10, FontStyle.Underline);
                    i += 4;
                }

                if (document.Find("CPAP/BIPAP",
                    RichTextBoxFinds.WholeWord) > 2)
                {
                    document.SelectionFont = new Font("SansSerif", 10, FontStyle.Underline);
                }
                if (document.Find("ABG",
                    RichTextBoxFinds.WholeWord) > 2)
                {
                    document.SelectionFont = new Font("SansSerif", 10, FontStyle.Underline);
                }


                if (document.Find(
                    Protocol.ProtocolTitle.Trim(), //99999
                    RichTextBoxFinds.MatchCase) > 2)
                {
                    document.SelectionFont = new Font("SansSerif", 10, FontStyle.Underline);
                    document.SelectionAlignment = HorizontalAlignment.Center;
                }

                formatTitleString("Technician Documentation");
            }
        }

        private void formatTitleString(string str)
        {
            if (document.Find(str, RichTextBoxFinds.MatchCase) > 2)
            {
                document.SelectionFont = new Font("SansSerif", 10, FontStyle.Underline);
                document.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void SetSleepProtocolTitle()
        {
            var str = protocolTitle;
            if (str == "")
            {
                var tx = new textInput();
                tx.Text = "Protocol Title?";

                if (tx.ShowDialog() == DialogResult.OK)
                {
                    str = tx.document.Text + "\r\n\n";
                    SetSleepProtocolTitle(str);
                    protocolTitle = str;
                }
            }
            else
                SetSleepProtocolTitle(str);
        }

        private void SetSleepProtocolTitle(string str)
        {
            Protocol.ProtocolTitle = str;
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            //this.menuItem20.Enabled=false;
            var theMedList = new medList(medPath);
            theMedList.groupBox_removeMed.Visible = false;
            theMedList.Show();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            document.Copy();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            document.Cut();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            document.Paste();
        }

        private void menuItem12_Click_1(object sender, EventArgs e)
        {
            var abg = new ABG();
            abg.Show();
        }

        private void menuItem14_Click_1(object sender, EventArgs e)
        {
            document.Copy();
        }

        private void menuItem15_Click_1(object sender, EventArgs e)
        {
            document.Cut();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            document.Paste();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            document.SelectAll();
        }

        private void menuItem21_Click(object sender, EventArgs e)
        {
            var theMed = new MedListUtil();
            theMed.RemoveDupDelegate();
        }

        private void menuItem22_Click(object sender, EventArgs e)
        {
            var med = new MedListUtil();
            med.ToLowerCaseDelegate();
        }

        private void menuItem23_Click(object sender, EventArgs e)
        {
            var theMed = new MedListUtil();
            theMed.RemoveFlagDelegate();
        }

        private void menuItem24_Click(object sender, EventArgs e)
        {
            var theMedList = new medList();
            theMedList.groupBox_main.Visible = false;
            theMedList.ShowDialog();
        }

        private void menuItem19_Popup(object sender, EventArgs e)
        {
            if (medList.isOpen)
            {
                menuItem20.Enabled = false;
            }
            else
                menuItem20.Enabled = true;
        }

        private void menuItem25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VER: 1.0.0\rCopyright(R): 11-08\rDamon L. German BS, RPSGT", "sleepEdit");
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            printDialog1.PrinterSettings.Copies = 1;
        }

        private void changeProtocolTitle_Click(object sender, EventArgs e)
        {
            protocolTitle = ""; //reset protocol title
            SetSleepProtocolTitle();
        }

        private void menuItem28_Click(object sender, EventArgs e)
        {
            var pe = new ProtocolEditUi();
            pe.ShowDialog();
        }

        private void menuItem29_Click(object sender, EventArgs e)
        {
            getPathToTheMainProtocolFile();
        }

        private void bmiCalcMenuItem_Click(object sender, EventArgs e)
        {
            var calc = new BmiCalcUi();
            calc.Show();
        }

        private void menuItem27_Click(object sender, EventArgs e)
        {
            getPathToSleepEditDataFile();
        }

        private void menuItem30_Click(object sender, EventArgs e)
        {
            var host = new ProtocolWFHost();
            host.Show();
        }

        #region variables

        internal ToolBar editToolBar;
        internal ToolBarButton openBarButton;
        internal ToolBarButton saveBarButton;
        internal ToolBarButton toolBarButton4;
        internal ToolBarButton printBarButton;
        internal ToolBarButton printPreviewBarButton;
        internal ToolBarButton toolBarButton5;
        internal ToolBarButton spellBarButton;
        internal ToolBarButton toolBarButton1;
        internal ToolBarButton cutBarButton;
        internal ToolBarButton copyBarButton;
        internal ToolBarButton pasteBarButton;
        internal ToolBarButton toolBarButton8;
        internal ToolBarButton undoBarButton;
        internal ToolBarButton redoBarButton;
        internal ToolBarButton toolBarButton11;
        internal ToolBarButton fontBarButton;
        internal ToolBarButton toolBarButton2;
        internal ToolBarButton boldBarButton;
        internal ToolBarButton italicBarButton;
        internal ToolBarButton underlineBarButton;
        internal ToolBarButton toolBarButton6;
        internal ToolBarButton leftBarButton;
        internal ToolBarButton centerBarButton;
        internal ToolBarButton rightBarButton;
        internal ToolBarButton toolBarButton12;
        internal ToolBarButton bulletsBarButton;
        internal ToolBarButton toolBarButton3;
        internal ToolBarButton fontColorBarButton;
        private ImageList toolBarImages;
        private RichTextBoxPrintCtrl.RichTextBoxPrintCtrl document;
        private MainMenu mainMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem_open;
        private MenuItem menuItem_save;
        private MenuItem menuItem2;
        private MenuItem menuItem_print;
        private MenuItem menuItem_pageSetup;
        private MenuItem menuItem_printPreview;
        private MenuItem menuItem3;
        private MenuItem menuItem_exit;
        private MenuItem menuItem4;
        private MenuItem menuItem7;
        private MenuItem menuItem11;
        private MenuItem menuItem13;
        private MenuItem menuItem16;
        private MenuItem menuItem_undo;
        private MenuItem menuItem_redo;
        private MenuItem menuItem_cut;
        private MenuItem menuItem_copy;
        private MenuItem menuItem_paste;
        private MenuItem menuItem_selectAll;
        private MenuItem menuItem_wordwrap;
        private MenuItem menuItem_font;
        private MenuItem menuItem_spelling;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printDocument1;
        private PageSetupDialog pageSetupDialog1;
        private WordDictionary wordDictionary1;
        private MenuItem menuItem_new;
        private IContainer components;
        private string fileName = "Untitled";
        private Spelling spelling;
        private ToolBarButton newBarButton;
        private MenuItem menuItem5;
        private MenuItem menuItem6;
        private MenuItem menuItem8;
        private MenuItem menuItem9;
        private MenuItem menuItem10;
        private ContextMenu contextMenu1;
        private MenuItem menuItem12;
        private ContextMenu contextMenu;
        private MenuItem menuItem14;
        private MenuItem menuItem15;
        private MenuItem menuItem17;
        private MenuItem menuItem18;
        private MenuItem menuItem19;
        private MenuItem menuItem20;
        private MenuItem menuItem21;
        private MenuItem menuItem22;
        private MenuItem menuItem23;
        private MenuItem menuItem24;
        private MenuItem menuItem25;
        //99999 Setting variables
        public static string medPath = Application.StartupPath + @"\data files\medlist.txt";
        private static readonly string dictionaryPath = Application.StartupPath + @"\data files";
        public static string sleepEditDataPath = "";
        public static string prelimIntPath = "";
        public static string workDirPath = "";
        public static string protocolTitle = "Sleep Lab\r\n";
        public static string protocolPath = "";
        public static ArrayList techList = new ArrayList();
        public static ArrayList maskType = new ArrayList();
        public static ArrayList maskSize = new ArrayList();
        private MenuItem menuItem26;
        private MenuItem menuItem28;
        private MenuItem menuItem29;
        private MenuItem bmiCalcMenuItem;
        private int checkPrint;
        private MenuItem menuItem27;

        private SleepEditDataManager mManager;

        #endregion
    }
}