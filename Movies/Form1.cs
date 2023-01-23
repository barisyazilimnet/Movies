using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MovieDal _movieDal = new MovieDal();
        private void LoadMovies()
        {
            Clear();
            dgwMovies.DataSource = _movieDal.GetAll();
            tbxTotal.Text = _movieDal.GetAll().Count.ToString();
        }
        private void Clear()
        {
            tbxName.Text = "";
            tbxLink.Text = "";
            cbxType.SelectedIndex = 0;
            tbxType2.Text = "";
            chkbxIsDownloaded.Checked = false;
            tbxNameSearch.Text = "";
            chkbxIsDownloadedSerach.Checked = false;
            cbxTypeSearch.SelectedIndex = 0;
            tbxType2Search.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }
        private void chkbxIsDownloaded_CheckedChanged(object sender, EventArgs e)
        {
            tbxLink.Enabled = (!chkbxIsDownloaded.Checked);
            tbxLink.Text = (chkbxIsDownloaded.Checked) ? " " : tbxLink.Text;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "" && cbxType.SelectedIndex != 0)
            {
                if (_movieDal.IsName(tbxName.Text).Count <= 0)
                {
                    if (chkbxIsDownloaded.Checked == false)
                    {
                        if (tbxLink.Text == "")
                        {
                            MessageBox.Show("İndirildi şeçili değilken Link boş olamaz");
                        }
                        else
                        {
                            _movieDal.Add(new Movie
                            {
                                Name = tbxName.Text,
                                Link = tbxLink.Text,
                                IsDownloaded = chkbxIsDownloaded.Checked,
                                Type = cbxType.Text,
                                Type2 = tbxType2.Text,
                                AddDate = DateTime.Now,
                            });
                            MessageBox.Show(tbxName.Text + " Eklendi.");
                            LoadMovies();
                        }
                    }
                    else
                    {
                        _movieDal.Add(new Movie
                        {
                            Name = tbxName.Text,
                            Link = tbxLink.Text,
                            IsDownloaded = chkbxIsDownloaded.Checked,
                            Type = cbxType.Text,
                            Type2 = tbxType2.Text,
                            AddDate = DateTime.Now,
                        });
                        MessageBox.Show(tbxName.Text + " Eklendi.");
                        LoadMovies();
                    }
                }
                else
                {
                    MessageBox.Show("İsmini girdiğiniz film/dizi listenizde bulunmaktadır.");
                }
            }
            else
            {
                MessageBox.Show("Film ismi ve türü boş bırakılamaz");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "" && cbxType.SelectedIndex != 0)
            {
                _movieDal.Update(new Movie
                {
                    Id = Convert.ToInt32(dgwMovies.CurrentRow.Cells[0].Value),
                    Name = tbxName.Text,
                    Link = tbxLink.Text,
                    IsDownloaded = chkbxIsDownloaded.Checked,
                    Type = cbxType.Text,
                    Type2 = tbxType2.Text,
                    AddDate = DateTime.Now,
                });
                MessageBox.Show(tbxName.Text + " Güncellendi.");
                LoadMovies();
            }
            else
            {
                MessageBox.Show("Film ismi ve türü boş bırakılamaz");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _movieDal.Update(new Movie
            {
                Id = Convert.ToInt32(dgwMovies.CurrentRow.Cells[0].Value),
                Name = dgwMovies.CurrentRow.Cells[1].Value.ToString(),
                Link = dgwMovies.CurrentRow.Cells[5].Value.ToString(),
                IsDownloaded = Convert.ToBoolean(dgwMovies.CurrentRow.Cells[2].Value),
                Type = dgwMovies.CurrentRow.Cells[3].Value.ToString(),
                Type2 = dgwMovies.CurrentRow.Cells[4].Value.ToString(),
                IsDeleted = true,
                AddDate = DateTime.Now,
            });
            MessageBox.Show(dgwMovies.CurrentRow.Cells[1].Value.ToString() + " Silindi.");
            LoadMovies();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }
        private void tbxNameSearch_TextChanged(object sender, EventArgs e)
        {
            dgwMovies.DataSource = _movieDal.GetAll().Where(m => m.Name.ToLower().Contains(tbxNameSearch.Text.ToLower())).ToList();
            cbxTypeSearch.SelectedIndex = 0;
            tbxType2Search.Text = "";
            chkbxIsDownloadedSerach.Checked = false;
            tbxTotal.Text = _movieDal.GetAll().Where(m => m.Name.ToLower().Contains(tbxNameSearch.Text.ToLower())).Count().ToString();
        }
        private void dgwMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwMovies.CurrentRow.Cells[1].Value.ToString();
            chkbxIsDownloaded.Checked = Convert.ToBoolean(dgwMovies.CurrentRow.Cells[2].Value);
            cbxType.Text = dgwMovies.CurrentRow.Cells[3].Value.ToString();
            tbxType2.Text = dgwMovies.CurrentRow.Cells[4].Value.ToString();
            tbxLink.Text = dgwMovies.CurrentRow.Cells[5].Value.ToString();
        }
        private void chkbxIsDownloadedSerach_CheckedChanged(object sender, EventArgs e)
        {
            dgwMovies.DataSource = _movieDal.GetAll().Where(m => m.IsDownloaded == chkbxIsDownloadedSerach.Checked).ToList();
            tbxNameSearch.Text = "";
            cbxTypeSearch.SelectedIndex = 0;
            tbxType2Search.Text = "";
            tbxTotal.Text = _movieDal.GetAll().Where(m => m.IsDownloaded == chkbxIsDownloadedSerach.Checked).Count().ToString();
        }
        private void cbxTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwMovies.DataSource = _movieDal.GetAll().Where(m => m.Type == cbxTypeSearch.SelectedItem.ToString()).ToList();
            tbxNameSearch.Text = "";
            tbxType2Search.Text = "";
            chkbxIsDownloadedSerach.Checked = false;
            tbxTotal.Text = _movieDal.GetAll().Where(m => m.Type == cbxTypeSearch.SelectedItem.ToString()).Count().ToString();
        }
        private void tbxType2Search_TextChanged(object sender, EventArgs e)
        {
            dgwMovies.DataSource = _movieDal.GetAll().Where(m => m.Type2.ToLower().Contains(tbxType2Search.Text.ToLower())).ToList();
            tbxNameSearch.Text = "";
            cbxTypeSearch.SelectedIndex = 0;
            chkbxIsDownloadedSerach.Checked = false;
            tbxTotal.Text = _movieDal.GetAll().Where(m => m.Type2.ToLower().Contains(tbxType2Search.Text.ToLower())).Count().ToString();
        }
    }
}
