using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExtratorLoteCFe.CFe;

namespace ExtratorLoteCFe
{
    public partial class FrmMain : Form
    {

        int m_sortColumn = -1;

        OpenFileDialog m_openFileDialog;
        FolderBrowserDialog m_folderBrowserDialog;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {


            m_openFileDialog = new OpenFileDialog();
            m_openFileDialog.Filter = "Arquivos XML|*.xml|Todos os Arquivos|*.*";
            m_openFileDialog.CheckFileExists = true;
            m_openFileDialog.Multiselect = true;
            m_openFileDialog.CheckPathExists = true;

            m_folderBrowserDialog = new FolderBrowserDialog();



        }

        private void btn_Select_ButtonClick(object sender, EventArgs e)
        {
            selectFiles();
        }

        private void selectFiles()
        {
            List<CFe.Node.Node> cfes = new List<CFe.Node.Node>();

            if (m_openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && m_openFileDialog.FileNames.Length > 0)
            {
                foreach (XMLFile xml in XMLFile.LoadFile(m_openFileDialog.FileNames))
                {
                    cfes.AddRange(xml.getCFes().Cast<CFe.Node.Node>());
                }
            }

            updateListView(cfes);

            


        }

        private void exitApp()
        {
            Close();
        }

        private void showToolbar(bool show)
        {
            toolbar.Visible = show;
        }
        private void showStatusbar(bool show)
        {
            statusbar.Visible = show;
        }

        private void lstViewClear()
        {
            lstView.Items.Clear();
        }
        private void selectAll(bool select = true)
        {
            if (lstView.Items.Count > 0)
            {
                foreach (ListViewItem item in lstView.Items)
                {
                    item.Checked = select;
                    item.Selected = select;
                }
            }
        }

        private void updateListView(List<CFe.Node.Node> nodes)
        {
            lstView.Items.Clear();
            foreach (CFe.Node.Node node in nodes)
            {
                ListViewItem item = new ListViewItem(node.Tipo);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, node.infCFeId));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, node.nserieSAT));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, node.nCFe));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, node.dateEmi.ToString("dd/MM/yyyy HH:mm:ss")));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, node.total));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, node.IdLote));
                item.Tag = node;
                lstView.Items.Add(item);
            }
        }

        private void lstView_selectAll_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void lstView_unselectAll_Click(object sender, EventArgs e)
        {
            selectAll(false);
        }

        private void lstView_clear_Click(object sender, EventArgs e)
        {
            lstViewClear();
        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void btn_unselectAll_Click(object sender, EventArgs e)
        {
            selectAll(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstViewClear();
        }

        private void btn_selectFiles_Click(object sender, EventArgs e)
        {
            selectFiles();
        }

        private void menu_item_select_file_Click(object sender, EventArgs e)
        {
            selectFiles();
        }

        private void menu_item_exit_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void lstView_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            if (e.Column != m_sortColumn)
            {
                // Set the sort column to the new column.
                m_sortColumn = e.Column;
                // Set the sort order to ascending by default.
                lstView.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (lstView.Sorting == SortOrder.Ascending)
                    lstView.Sorting = SortOrder.Descending;
                else
                    lstView.Sorting = SortOrder.Ascending;
            }

            lstView.ListViewItemSorter = new ListViewItemComparer(e.Column, lstView.Sorting);
            lstView.Sort();
        }

        private void menu_item_show_toolbar_Click(object sender, EventArgs e)
        {
            showToolbar(menu_item_show_toolbar.Checked);
        }

        private void menu_item_show_statusbar_Click(object sender, EventArgs e)
        {
            showStatusbar(menu_item_show_statusbar.Checked);
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportAllSelecteds();
        }

        private void exportAllSelecteds()
        {
            if (lstView.CheckedItems.Count > 0)
            {
                List<CFe.Node.Node> nodes = new List<CFe.Node.Node>();

                foreach (ListViewItem item in lstView.CheckedItems)
                {
                    nodes.Add((CFe.Node.Node)item.Tag);
                }

                
                exportItems(nodes);

            }


        }

        private void exportItems(List<CFe.Node.Node> nodes)
        {
            if (m_folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = m_folderBrowserDialog.SelectedPath;
                int exports = 0;

                foreach (CFe.Node.Node node in nodes)
                {
                    if (node.exists(folder))
                    {
                        switch (MessageBox.Show(
                            this,
                            String.Format("O arquivo {0} já existe, deseja substituir?", node.FileName),
                            "Confirmação",
                            MessageBoxButtons.YesNoCancel
                        ))
                        {
                            case System.Windows.Forms.DialogResult.Yes:
                                node.exportTo(folder);
                                exports++;
                                break;
                            case System.Windows.Forms.DialogResult.Cancel:
                                return;
                        }
                    }
                    else
                    {
                        exports++;
                        node.exportTo(folder);
                    }
                    
                }


                if (exports > 0)
                {
                    MessageBox.Show(this, String.Format("Foram Exportado {0} Notas", exports));
                }
            }
        }

        private void btn_export_ButtonClick(object sender, EventArgs e)
        {
            exportAllSelecteds();
        }

        private void btn_exportAll_Click(object sender, EventArgs e)
        {
            exportAllSelecteds();
        }

        private void menu_item_about_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }
    }
}
