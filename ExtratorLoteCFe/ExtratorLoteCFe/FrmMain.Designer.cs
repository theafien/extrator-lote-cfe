namespace ExtratorLoteCFe
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_select_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_select_folder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_item_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_show_toolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_show_statusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.btn_Select = new System.Windows.Forms.ToolStripSplitButton();
            this.btn_selectFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_selectFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_selectAll = new System.Windows.Forms.ToolStripButton();
            this.btn_unselectAll = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_export = new System.Windows.Forms.ToolStripSplitButton();
            this.btn_exportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exportSold = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exportCanceled = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarTodosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.lstView_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.lstView_unselectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.lstView_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.lstViewContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(638, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecionarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.menu_item_settings,
            this.toolStripMenuItem2,
            this.menu_item_exit});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // selecionarToolStripMenuItem
            // 
            this.selecionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_select_file,
            this.menu_item_select_folder});
            this.selecionarToolStripMenuItem.Name = "selecionarToolStripMenuItem";
            this.selecionarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selecionarToolStripMenuItem.Text = "&Selecionar";
            // 
            // menu_item_select_file
            // 
            this.menu_item_select_file.Name = "menu_item_select_file";
            this.menu_item_select_file.Size = new System.Drawing.Size(152, 22);
            this.menu_item_select_file.Text = "&Arquivos...";
            this.menu_item_select_file.Click += new System.EventHandler(this.menu_item_select_file_Click);
            // 
            // menu_item_select_folder
            // 
            this.menu_item_select_folder.Enabled = false;
            this.menu_item_select_folder.Name = "menu_item_select_folder";
            this.menu_item_select_folder.Size = new System.Drawing.Size(152, 22);
            this.menu_item_select_folder.Text = "&Pasta...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // menu_item_settings
            // 
            this.menu_item_settings.Enabled = false;
            this.menu_item_settings.Name = "menu_item_settings";
            this.menu_item_settings.Size = new System.Drawing.Size(152, 22);
            this.menu_item_settings.Text = "&Configurações";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // menu_item_exit
            // 
            this.menu_item_exit.Name = "menu_item_exit";
            this.menu_item_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menu_item_exit.Size = new System.Drawing.Size(152, 22);
            this.menu_item_exit.Text = "&Sair";
            this.menu_item_exit.Click += new System.EventHandler(this.menu_item_exit_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_show_toolbar,
            this.menu_item_show_statusbar});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "&Exibir";
            // 
            // menu_item_show_toolbar
            // 
            this.menu_item_show_toolbar.Checked = true;
            this.menu_item_show_toolbar.CheckOnClick = true;
            this.menu_item_show_toolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_item_show_toolbar.Name = "menu_item_show_toolbar";
            this.menu_item_show_toolbar.Size = new System.Drawing.Size(185, 22);
            this.menu_item_show_toolbar.Text = "Barra de Ferramentas";
            this.menu_item_show_toolbar.Click += new System.EventHandler(this.menu_item_show_toolbar_Click);
            // 
            // menu_item_show_statusbar
            // 
            this.menu_item_show_statusbar.Checked = true;
            this.menu_item_show_statusbar.CheckOnClick = true;
            this.menu_item_show_statusbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_item_show_statusbar.Name = "menu_item_show_statusbar";
            this.menu_item_show_statusbar.Size = new System.Drawing.Size(185, 22);
            this.menu_item_show_statusbar.Text = "Barra de Estado";
            this.menu_item_show_statusbar.Click += new System.EventHandler(this.menu_item_show_statusbar_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_about});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // menu_item_about
            // 
            this.menu_item_about.Name = "menu_item_about";
            this.menu_item_about.Size = new System.Drawing.Size(152, 22);
            this.menu_item_about.Text = "&Sobre";
            this.menu_item_about.Click += new System.EventHandler(this.menu_item_about_Click);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusbar.Location = new System.Drawing.Point(0, 353);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(638, 22);
            this.statusbar.TabIndex = 1;
            this.statusbar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Pronto";
            // 
            // toolbar
            // 
            this.toolbar.AllowItemReorder = true;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Select,
            this.toolStripSeparator1,
            this.btn_selectAll,
            this.btn_unselectAll,
            this.btnClear,
            this.toolStripSeparator2,
            this.btn_export,
            this.toolStripLabel1});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(638, 25);
            this.toolbar.TabIndex = 2;
            this.toolbar.Text = "toolStrip1";
            // 
            // btn_Select
            // 
            this.btn_Select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Select.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_selectFiles,
            this.btn_selectFolder});
            this.btn_Select.Image = global::ExtratorLoteCFe.Properties.Resources.folder_vertical_document;
            this.btn_Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(32, 22);
            this.btn_Select.Text = "toolStripSplitButton1";
            this.btn_Select.ButtonClick += new System.EventHandler(this.btn_Select_ButtonClick);
            // 
            // btn_selectFiles
            // 
            this.btn_selectFiles.Name = "btn_selectFiles";
            this.btn_selectFiles.Size = new System.Drawing.Size(187, 22);
            this.btn_selectFiles.Text = "Selecionar Arquivos...";
            this.btn_selectFiles.Click += new System.EventHandler(this.btn_selectFiles_Click);
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.Enabled = false;
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(187, 22);
            this.btn_selectFolder.Text = "Selecionar Pasta...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_selectAll
            // 
            this.btn_selectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_selectAll.Image = global::ExtratorLoteCFe.Properties.Resources.group_stroke;
            this.btn_selectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_selectAll.Name = "btn_selectAll";
            this.btn_selectAll.Size = new System.Drawing.Size(23, 22);
            this.btn_selectAll.Text = "Selecionar Todos";
            this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
            // 
            // btn_unselectAll
            // 
            this.btn_unselectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_unselectAll.Image = global::ExtratorLoteCFe.Properties.Resources.ungroup_stroke;
            this.btn_unselectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_unselectAll.Name = "btn_unselectAll";
            this.btn_unselectAll.Size = new System.Drawing.Size(23, 22);
            this.btn_unselectAll.Text = "Deselecionar Todos";
            this.btn_unselectAll.Click += new System.EventHandler(this.btn_unselectAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = global::ExtratorLoteCFe.Properties.Resources.table_delete;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_export
            // 
            this.btn_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_exportAll,
            this.btn_exportSold,
            this.btn_exportCanceled});
            this.btn_export.Image = global::ExtratorLoteCFe.Properties.Resources.saved_exports;
            this.btn_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(32, 22);
            this.btn_export.Text = "Exportar Todos";
            this.btn_export.ButtonClick += new System.EventHandler(this.btn_export_ButtonClick);
            // 
            // btn_exportAll
            // 
            this.btn_exportAll.Name = "btn_exportAll";
            this.btn_exportAll.Size = new System.Drawing.Size(181, 22);
            this.btn_exportAll.Text = "Exportar Todos";
            this.btn_exportAll.Click += new System.EventHandler(this.btn_exportAll_Click);
            // 
            // btn_exportSold
            // 
            this.btn_exportSold.Enabled = false;
            this.btn_exportSold.Name = "btn_exportSold";
            this.btn_exportSold.Size = new System.Drawing.Size(181, 22);
            this.btn_exportSold.Text = "Exportar Vendidos";
            // 
            // btn_exportCanceled
            // 
            this.btn_exportCanceled.Enabled = false;
            this.btn_exportCanceled.Name = "btn_exportCanceled";
            this.btn_exportCanceled.Size = new System.Drawing.Size(181, 22);
            this.btn_exportCanceled.Text = "Exportar Cancelados";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(180, 22);
            this.toolStripLabel1.Text = "Desenvolvido por Gilson Fabiano";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 304);
            this.panel1.TabIndex = 3;
            // 
            // lstView
            // 
            this.lstView.AllowColumnReorder = true;
            this.lstView.AllowDrop = true;
            this.lstView.CheckBoxes = true;
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstView.ContextMenuStrip = this.lstViewContextMenu;
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.FullRowSelect = true;
            this.lstView.GridLines = true;
            this.lstView.Location = new System.Drawing.Point(0, 0);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(638, 304);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstView_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chave de Acesso";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "N. Série SAT";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "N. Documento";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data/Hora";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lote";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tipo";
            this.columnHeader7.Width = 90;
            // 
            // lstViewContextMenu
            // 
            this.lstViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarTodosToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.lstView_selectAll,
            this.lstView_unselectAll,
            this.toolStripMenuItem3,
            this.lstView_clear});
            this.lstViewContextMenu.Name = "lstViewContextMenu";
            this.lstViewContextMenu.Size = new System.Drawing.Size(190, 104);
            // 
            // exportarTodosToolStripMenuItem1
            // 
            this.exportarTodosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.canceladosToolStripMenuItem,
            this.vendidosToolStripMenuItem});
            this.exportarTodosToolStripMenuItem1.Name = "exportarTodosToolStripMenuItem1";
            this.exportarTodosToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.exportarTodosToolStripMenuItem1.Text = "Exportar Selecionados";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // canceladosToolStripMenuItem
            // 
            this.canceladosToolStripMenuItem.Enabled = false;
            this.canceladosToolStripMenuItem.Name = "canceladosToolStripMenuItem";
            this.canceladosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.canceladosToolStripMenuItem.Text = "Cancelados";
            // 
            // vendidosToolStripMenuItem
            // 
            this.vendidosToolStripMenuItem.Enabled = false;
            this.vendidosToolStripMenuItem.Name = "vendidosToolStripMenuItem";
            this.vendidosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vendidosToolStripMenuItem.Text = "Vendidos";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 6);
            // 
            // lstView_selectAll
            // 
            this.lstView_selectAll.Name = "lstView_selectAll";
            this.lstView_selectAll.Size = new System.Drawing.Size(189, 22);
            this.lstView_selectAll.Text = "Selecionar todos";
            this.lstView_selectAll.Click += new System.EventHandler(this.lstView_selectAll_Click);
            // 
            // lstView_unselectAll
            // 
            this.lstView_unselectAll.Name = "lstView_unselectAll";
            this.lstView_unselectAll.Size = new System.Drawing.Size(189, 22);
            this.lstView_unselectAll.Text = "Deselecionar todos";
            this.lstView_unselectAll.Click += new System.EventHandler(this.lstView_unselectAll_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 6);
            // 
            // lstView_clear
            // 
            this.lstView_clear.Name = "lstView_clear";
            this.lstView_clear.Size = new System.Drawing.Size(189, 22);
            this.lstView_clear.Text = "Limpar";
            this.lstView_clear.Click += new System.EventHandler(this.lstView_clear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "FrmMain";
            this.Text = "Extrator de Lote CFe";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.lstViewContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_item_select_file;
        private System.Windows.Forms.ToolStripMenuItem menu_item_select_folder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_item_settings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menu_item_exit;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_item_show_toolbar;
        private System.Windows.Forms.ToolStripMenuItem menu_item_show_statusbar;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_item_about;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip lstViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem lstView_selectAll;
        private System.Windows.Forms.ToolStripMenuItem lstView_unselectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem lstView_clear;
        private System.Windows.Forms.ToolStripSplitButton btn_Select;
        private System.Windows.Forms.ToolStripMenuItem btn_selectFiles;
        private System.Windows.Forms.ToolStripMenuItem btn_selectFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_selectAll;
        private System.Windows.Forms.ToolStripButton btn_unselectAll;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton btn_export;
        private System.Windows.Forms.ToolStripMenuItem btn_exportAll;
        private System.Windows.Forms.ToolStripMenuItem btn_exportSold;
        private System.Windows.Forms.ToolStripMenuItem btn_exportCanceled;
        private System.Windows.Forms.ToolStripMenuItem exportarTodosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canceladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

